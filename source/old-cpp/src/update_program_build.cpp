#include <map>
#include <list>
#include <vector>
#include <sstream>
#include <iostream>
#include <exo/memory_space.hpp>
#include <boost/filesystem.hpp>
#include <boost/filesystem/fstream.hpp>
#include <boost/unordered_map.hpp>
#include <boost/functional/hash.hpp>


using namespace exo;
using namespace boost::filesystem;


const size_t group_files_size_max = 30000; // in bytes
path srcdir;

static boost::unordered_map<path, size_t> get_files()
{
    boost::unordered_map<path, size_t> files;


    std::list<path> search_dirctory;

    search_dirctory.push_back(srcdir / "program/auto/");
    search_dirctory.push_back(srcdir / "program/manual/");


    while (search_dirctory.empty() == false)
    {
        for (auto file = directory_iterator(*search_dirctory.begin());
                file != directory_iterator();
                file++)
        {
            auto last_comp = file -> path().end();
            last_comp--;

            if (is_directory(file -> status()))
            {
                if (memory_space_const(last_comp -> string()).starts_with("."))
                    continue; // skip

                search_dirctory.push_back(file -> path());
            }
            else
                if (memory_space_const(last_comp -> string()).ends_with(".cpp"))
                {
//                    auto ret =
                            files.insert(std::make_pair(file -> path(), file_size(file -> path())));
//                    std::cout << ret.first -> first << ' ' << ret.first -> second << '\n';
                }
        }

        search_dirctory.pop_front();
    }

    return files;
}

static void forget_success_files(boost::unordered_map<path, size_t> & files)
{
    create_directory("program/build");

    for (auto iter_build_file = directory_iterator("program/build");
            iter_build_file != directory_iterator();
            iter_build_file++)
    {
        {
            auto last_comp = iter_build_file -> path().end();
            last_comp--;

            if (memory_space_const(last_comp -> string()).ends_with(".cpp") == false)
                continue;
        }



        bool success = true;
        size_t total_size = 0;
        size_t count_files = 0;
        std::vector<path> used_orig_files;


        boost::filesystem::ifstream build_file(iter_build_file -> path());
        for(std::string s; getline(build_file, s);)
        {
            if (s.size() == 0)
                continue;


            // string like '#include "..."'.
            if (s.size() < 11)
            {
                success = false;
                break;
            }

            s = s.substr(10, s.size() - 11);


            if (s == "program/auto.hpp")
                continue;


            auto orig_file = files.find(s);
            if (orig_file == files.end())
            {
                success = false;
                break;
            }
            else
            {
                count_files++;
                total_size += orig_file -> second;
                used_orig_files.push_back(orig_file -> first);
            }
        }

        if (1 < count_files && group_files_size_max < total_size)
            success = false;


        if (success)
        {
            std::cout << iter_build_file -> path().native() << '\n';
            for (auto f : used_orig_files)
                files.erase(f);
        }
        else
        {
            path p = iter_build_file -> path();
            remove(p); // remove .cpp

            p.replace_extension("o");
            remove(p); // remove .o

            path filename = p.filename();
            p.remove_filename();
            p /= ".deps";
            p /= filename;

            p.replace_extension("Po");
            remove(p); // remove .deps/.Po

            p.replace_extension("Tpo");
            remove(p); // remove .deps/.Tpo
        }
    }
}

static std::multimap<size_t, std::string> get_files_to_process()
{
    boost::unordered_map<path, size_t> files = get_files();
    forget_success_files(files);


    std::multimap<size_t, std::string> files_to_process;

    for (auto i : files)
        files_to_process.insert(std::make_pair(i.second, i.first.string()));

    return files_to_process;
}


int main(int argc, char * argv[])
{
    if (2 <= argc)
        srcdir = argv[1];

    std::multimap<size_t, std::string> files = get_files_to_process();

    while (files.empty() == false)
    {
        size_t files_size = 0;
        std::vector<std::string> group;

        files_size += files.rbegin() -> first;
        group.push_back(files.rbegin() -> second);
        files.erase(--files.end());

        if (files_size < group_files_size_max)
            for(;;)
            {
                const size_t left_size = group_files_size_max - files_size;

                auto iter = files.upper_bound(left_size);
                if (iter == files.begin())
                    break;
                iter--;

                files_size += iter -> first;
                group.push_back(iter -> second);
                files.erase(iter);
            }


        // generate filename.

        size_t hash = boost::hash_value(group);

        std::ostringstream os;
        os << "program/build/group_0x";

        auto ow = os.width(sizeof(size_t) * 2);
        auto of_ = os.fill('0');
        os << std::hex << hash;
        os.width(ow);
        os.fill(of_);

        os << ".cpp";


        std::ofstream ofs(os.str());
        ofs << "#include \"program/auto.hpp\"\n";
        for (auto i : group)
            ofs << "#include \"" << i << "\"\n";

        std::cout << os.str() << '\n';
    }

    return 0;
}
