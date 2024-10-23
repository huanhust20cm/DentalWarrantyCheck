import Layout from "@/components/layout/Layout";
import About from "@/components/sections/home1/About";
import Banner from "@/components/sections/home1/Banner";
import Features from "@/components/sections/home1/Features";
import News from "@/components/sections/home1/News";
import Process from "@/components/sections/home1/Process";
import Services from "@/components/sections/home1/Services";
import Subscribe from "@/components/sections/home1/Subscribe";
import Team from "@/components/sections/home1/Team";
import Video from "@/components/sections/home1/Video";
import WhyChooseUs from "@/components/sections/home1/WhyChooseUs";

export default function Home() {
  return (
    <Layout headerStyle={1} footerStyle={1}>
      <Banner />
      <Features />
      <About />
      <Services />
      <WhyChooseUs />
      <Team />
      <Video />
      <Process />
      <News />
      <Subscribe />
    </Layout>
  );
}
