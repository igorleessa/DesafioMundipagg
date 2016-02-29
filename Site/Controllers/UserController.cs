using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Site.Models;
using DAL.Entity;
using DAL.Persistence;
using System.Web.Security;

namespace Site.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        
        //Logout do sistema
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            Session.Remove("systemuser");
            Session.Abandon();

            return View("Login");
        }


        //cadastro de usuário
        [HttpPost]
        public ActionResult RegisterUser(RegisterModel model)
        {
            try
            {
                //verifica se validação esta OK
                if (ModelState.IsValid)
                {
                    if (model.UserPassword.Equals(model.UserPasswordConfirm))
                    {
                        SystemUserDal su = new SystemUserDal();

                        if (!su.HasLogin(model.UserLogin))
                        {
                            SystemUser u = new SystemUser();
                            u.UserName = model.UserName;
                            u.UserCpf = model.UserCpf;
                            u.UserBirth = model.UserBirth;
                            u.UserGender = model.UserGender;
                            u.AddressCep = model.AddressCep;
                            u.AddressStreet = model.AddressStreet;
                            u.AddressNumber = model.AddressNumber;
                            u.AddressComplement = model.AddressComplement;
                            u.AddressCity = model.AddressCity;
                            u.AddressState = model.AddressState;
                            u.AddressDistrict = model.AddressDistrict;
                            u.UserLogin = model.UserLogin;
                            //u.UserPassword = model.UserPassword;
                            u.UserPassword = CriptographyPass.EncryptMD5(model.UserPassword);

                            su.InsertUser(u);

                            ViewBag.Message = "Usuário " + u.UserLogin + " cadastrado com sucesso.";
                            ModelState.Clear();
                        }
                        else
                        {
                          throw new Exception("Erro. Login já existe.");
                        }
                    }
                    else
                    {
                        throw new Exception("Erro. Senha incorreta.");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message; ;
            }
            
            return View("Register");
        }




        //Login
        [HttpPost]
        public ActionResult UserLogin(LoginModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SystemUserDal d = new SystemUserDal();
                    SystemUser u = d.Find(model.UserLogin, CriptographyPass.EncryptMD5(model.UserPassword));
                    if (u != null)
                    {
                        FormsAuthentication.SetAuthCookie(u.UserLogin, false);
                        Session.Add("systemuser", u.UserName);

                        return RedirectToAction("Home", "Admin");
                    }
                    else
                    {
                        ViewBag.Message = "Acesso Negado. Tente Novamente.";
                    }

                }
            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
            }

            return View("Login");

        }
    }
}
