"use client";
import { useState } from "react";
import ModalVideo from "react-modal-video";
export default function Video() {
  const [isOpen, setOpen] = useState(false);
  return (
    <>
      <section className="video-section p_relative">
        <div
          className="bg-layer parallax-bg"
          data-parallax='{"y": 100}'
          style={{
            backgroundImage: "url(assets/images/resource/video.jpg)",
          }}
        ></div>
        <figure className="image-layer">
          <img src="assets/images/resource/video-1.png" alt="" />
        </figure>
        <div className="auto-container">
          <div className="inner-box">
            <div
              className="shape"
              style={{
                backgroundImage: "url(assets/images/shape/shape-17.png)",
              }}
            ></div>
             <h2>
              TỎA SÁNG CÙNG NỤ CƯỜI SANG VỚI RĂNG SỨ <br />
              CERCONIA
            </h2>
            <div className="video-btn">
              <a onClick={() => setOpen(true)}>
                <i className="fas fa-play"></i>
                <span className="border-animation border-1"></span>
                <span className="border-animation border-2"></span>
                <span className="border-animation border-3"></span>
              </a>
            </div>
          </div>
        </div>
      </section>
      <ModalVideo
        channel="youtube"
        autoplay
        isOpen={isOpen}
        videoId="nfP5N9Yc72A"
        onClose={() => setOpen(false)}
      />
    </>
  );
}
