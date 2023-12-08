using lab2._3.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2._3.Controllers
{

    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult ShowMusic()
        {
            List<Music> musicList = GetMusicList();
            return View(musicList);
        }

    
        // GET : Details Music
        public ActionResult DetailsMusic(int? musicId , string musicName, string audioFilePath, string error)
        {
            if(musicId == null)
            {

                //ViewBag.ErrorMessage = "Không tìm thấy thông tin âm nhạc";
                //return View("Error");
                return HttpNotFound();
            }

            Music music = GetMusicList().FirstOrDefault(m => m.Id1 == musicId);

            if(music == null)
            {
                return HttpNotFound();
                //ViewBag.ErrorMessage = "Không tìm thấy thông tin âm nhạc";
                //return View("Error");
            }

            ViewBag.musicName = music.Title1;
            audioFilePath = Url.Content("~/Content/"+music.FileName1);
            ViewBag.AudioFilePath = audioFilePath;
            return View();  
        }
        
         // GET : Download Music
        public ActionResult Download(int? musicId)
        {
            if(musicId == null)
            {
                return HttpNotFound();
            }

            Music music = GetMusicList().FirstOrDefault(m => m.Id1 == musicId);

            if(music == null)
            {
                return HttpNotFound();

            }   
            

            byte[] fileByte = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/"+music.FileName1));
            string fileName = music.FileName1; 

            return File(fileByte, "audio/mp3", fileName);
        }
        // GET: Music/PlayAudio
      
        public ActionResult RedirectToPlayAudio()
        {
            return RedirectToAction("PlayAudio");
        }

        private List<Music> GetMusicList()
        {
            List<Music> musicList = new List<Music>
            {
             new Music(1, "WREN EVANS - TỪNG QUEN | OFFICIAL AUDIO", "tungquen.mp3"),
             new Music(2, "Con Đường Hạnh Phúc | Thùy Chi ", "conduonghanhphuc.mp3"),
             new Music(3, "Đôi Mươi | Hoàng Dũng", "doimuoi.mp3"),
             new Music(4, "THÁI ĐINH | PHỐ KHÔNG EM ", "phokhongem.mp3"),


        };
            return musicList;
        }
    }
}