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

const socialMediaLinks = [
  { icon: <RiYoutubeLine />, href: "link-do-youtube" },
  { icon: <RiFacebookBoxLine />, href: "link-do-facebook" },
  { icon: <RiInstagramLine />, href: "link-do-instagram" },
  { icon: <RiDribbbleLine />, href: "link-do-dribbble" },
  { icon: <RiBehanceLine />, href: "link-do-behance" },
  { icon: <RiPinterestLine />, href: "link-do-pinterest" },
];

const Socials = () => {
  return (
    <div className="flex items-center gap-x-5 text-lg">
      {socialMediaLinks.map((item, index) => (
        <Link
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
