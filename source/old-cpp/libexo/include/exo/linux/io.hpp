#ifndef EXO_LINUX_IO_HPP_INCLUDED
#define EXO_LINUX_IO_HPP_INCLUDED

#include <exo/process.hpp>
#include <exo/attributes.hpp>
#include <exo/memory_space.hpp>

#include <exo/linux/time.hpp>
#include <exo/linux/types.hpp>


#ifdef linux
/* Объявлять "linux" маленькими буквами было плохой идеей. Следовало бы объявить "LINUX". */
#undef linux
#endif


namespace exo {
namespace linux {


/** const_file - Только использует файловый десктриптор. Деструктор ничего не делает. Копирующий конструктор разрещён.
 * file - Обеспечивает захват файлового дескриптора. В деструкторе происходит его закрытие. Копирующй конструктор запрещён. */

class stat;
class file;
class const_file;
class mapping;


class stat
{
private:

    detail::mode_t mode;    /* protection */

public:

    dev_t      dev;     /* ID of device containing file */
    ino_t      ino;     /* inode number */
    nlink_t    nlink;   /* number of hard links */
    uid_t      uid;     /* user ID of owner */
    gid_t      gid;     /* group ID of owner */
    dev_t      rdev;    /* device ID (if special file) */

    filesize_t size;    /* total size, in bytes */
    filesize_t alloc_size;  /* number of allocated bytes */

    time       atime;   /* time of last access */
    time       mtime;   /* time of last modification */
    time       ctime;   /* time of last status change */

private:

    stat(void * stat_buf);

public:

    stat(const_file file);

    static stat file(const_file file);
    static stat file(const char * name);
    static stat link_prefer(const char * name);


    file_perm get_perm() const
    {
        return static_cast<file_perm>(mode & (~ detail::file_type_mask));
    }

    file_type get_type() const
    {
        return static_cast<file_type>(mode & detail::file_type_mask);
    }
};


class const_file
{
public:

    typedef int descriptor_type;

protected:

    const descriptor_type fd;

    const_file()
    : fd(-1)
    {}

    explicit const_file(descriptor_type fd_)
    : fd(fd_)
    {}

public:

    /* Копирующий конструктор разрешён. */

    const_file & operator=(const const_file & x)
    {
        const_cast<descriptor_type&>(fd) = x.fd;
        return * this;
    }


    explicit operator descriptor_type() const
    {
        return fd;
    }


    bool is_open() const
    {
        return 0 <= fd;
    }

    bool is_close() const
    {
        return ! is_open();
    }


    /** @return Возвращает прочитанную область (начало buffer). */
    memory_space read(memory_space buffer) const __attribute_warn_unused_result__;
    /** @return Возвращает область которую осталось записать (конец buffer). */
    memory_space write(memory_space buffer) const __attribute_warn_unused_result__;

    /** В случае ошибки корректирут size у buffer и генерирует исключение. */
    void read_all(memory_space & buffer) const;
    /** В случае ошибки корректирут size у buffer и генерирует исключение. */
    void write_all(memory_space & buffer) const;

    mapping mmap(map_prot prot, map_type type) const;
    mapping mmap(map_prot prot, map_type type, filesize_t offset, filesize_t length) const;
    mapping mmap(map_prot prot, map_type type, filesize_t offset, filesize_t length, void * addr) const;

    linux::stat stat() const
    {
        return linux::stat(*this);
    }
};


#pragma GCC diagnostic push
/* У базового класса нет виртуального деструктора,
 * но в данном случае он нам и не нужен. Так что отключаем
 * соответствующее предупреждение компилятора. */
#pragma GCC diagnostic ignored "-Weffc++"

class file : public const_file
{
#pragma GCC diagnostic pop

private:

    void close_();

public:

    typedef const_file::descriptor_type descriptor_type;


    file()
    : const_file()
    {}

    explicit file(descriptor_type fd_)
    : const_file(fd_)
    {}

    file(const char * path, file_flags flags);
    file(const char * path, file_flags flags, file_perm perm);

    file(const file &) = delete;

    file(file && f)
    : const_file(f.release())
    {}

    ~file()
    {
        if (process::worked())
        {
            try
            {
                close();
            }
            catch(...) {}
        }
    }

    // any error - no exeption, only return closed class file.
    static file try_open(const char * path, file_flags flags);
    // no exist - class file closed, другая ошибка - exeption.
    static file open_if_exist(const char * path, file_flags flags);


    file & operator=(const file &) = delete;

    file & operator=(file && f)
    {
        close();
        static_cast<const_file&>(*this) = f.release();
        return *this;
    }


    explicit operator descriptor_type() const
    {
        return fd;
    }


    const_file release()
    {
        const_file ret = *this;
        const_cast<descriptor_type&>(fd) = -1;
        return ret;
    }

    /** @note Повторный вызов функции close не является ошибкой. */
    void close()
    {
        if (is_open())
            close_();
    }
};


class mapping
{
private:

    memory_space area;

    void unmap_();

public:
// @todo typedef max(size_t, filesize_t) internal_size_t.
    mapping()
    : area()
    {}

    explicit mapping(memory_space area_)
    : area(area_)
    {}

    mapping(map_prot prot, map_type type, filesize_t length);
    mapping(map_prot prot, map_type type, filesize_t length, void * addr);
    mapping(map_prot prot, map_type type, const_file file, filesize_t offset, filesize_t length);
    mapping(map_prot prot, map_type type, const_file file, filesize_t offset, filesize_t length, void * addr);

    mapping(const mapping &) = delete;

    mapping(mapping && m)
    : area(m.release())
    {}

    ~mapping()
    {
        if (process::worked())
        {
            try
            {
                unmap();
            }
            catch(...) {}
        }
    }


    mapping & operator=(const mapping &) = delete;

    mapping & operator=(mapping && m)
    {
        unmap();
        area = m.release();
        return * this;
    }


    operator memory_space() const
    {
        return area;
    }

    memory_space ms() const
    {
        return area;
    }

    /** Разделить mapping на две части. Первая часть возвращается (длина first) оставшееся остаётся в этом классе. */
    mapping split(filesize_t first);

    memory_space release()
    {
        memory_space ret = area;
        area = memory_space();
        return ret;
    }

    /** @note Повторный вызов функции unmap не является ошибкой. */
    void unmap()
    {
        if (area.is_not_empty())
            unmap_();
    }
};


} /* namespace linux */
} /* namespace exo */

#endif /* EXO_LINUX_IO_HPP_INCLUDED */
