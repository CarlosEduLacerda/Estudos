// links
import Link from "next/link";

// icons
import {
  RiYoutubeLine,
  RiInstagramLine,
  RiFacebookBoxLine,
  RiDribbbleLine,
  RiBehanceLine,
  RiPinterestLine,
} from "react-icons/ri";

import { FaLinkedin } from "react-icons/fa6";

import { IoLogoGithub } from "react-icons/io";

const socialMediaLinks = [
  {
    icon: <FaLinkedin />,
    href: "https://www.linkedin.com/in/carlos-lacerda-8a762b200/",
  },
  { icon: <RiFacebookBoxLine />, href: "link-do-facebook" },
  {
    icon: <RiInstagramLine />,
    href: "https://www.instagram.com/carlosedu_ls/",
  },
  {
    icon: <IoLogoGithub />,
    href: "https://github.com/CarlosEduLacerda",
  },
  { icon: <RiBehanceLine />, href: "link-do-behance" },
  { icon: <RiPinterestLine />, href: "link-do-pinterest" },
];

const Socials = () => {
  return (
    <div className="flex items-center gap-x-5 text-lg">
      {socialMediaLinks.map((item, index) => (
        <Link
          target="_blank"
          key={index}
          href={item.href}
          className="hover:text-accent transition-all duration-300"
        >
          {item.icon}
        </Link>
      ))}
    </div>
  );
};

export default Socials;
