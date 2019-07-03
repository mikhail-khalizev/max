#include "time_internal.hpp"

#include <fcntl.h>
#include <unistd.h>

#include <sys/ipc.h>
#include <sys/sem.h>
#include <sys/mman.h>
#include <sys/stat.h>
#include <sys/types.h>

#include <exo/linux/io.hpp>
#include <exo/linux/time.hpp>
#include <exo/linux/exception.hpp>


namespace exo {
namespace linux {


stat::stat(void * buf)
: mode(reinterpret_cast<struct ::stat *>(buf) -> st_mode)
, dev(reinterpret_cast<struct ::stat *>(buf) -> st_dev)
, ino(reinterpret_cast<struct ::stat *>(buf) -> st_ino)
, nlink(reinterpret_cast<struct ::stat *>(buf) -> st_nlink)
, uid(reinterpret_cast<struct ::stat *>(buf) -> st_uid)
, gid(reinterpret_cast<struct ::stat *>(buf) ->  st_gid)
, rdev(reinterpret_cast<struct ::stat *>(buf) -> st_rdev)
, size(static_cast<filesize_t>(reinterpret_cast<struct ::stat *>(buf) -> st_size))
, alloc_size(static_cast<filesize_t>(reinterpret_cast<struct ::stat *>(buf) -> st_blocks) * 512)
, atime(convert_timespec_to_time(reinterpret_cast<struct ::stat *>(buf) -> st_atim))
, mtime(convert_timespec_to_time(reinterpret_cast<struct ::stat *>(buf) -> st_mtim))
, ctime(convert_timespec_to_time(reinterpret_cast<struct ::stat *>(buf) -> st_ctim))
{
    auto & buf_ = * reinterpret_cast<struct ::stat *>(buf);

    if (buf_.st_size < 0
            || buf_.st_blksize < 0
            || buf_.st_blocks < 0
            || (alloc_size / 512) != static_cast<filesize_t>(buf_.st_blocks))
        throw std::out_of_range("Не удалось преобразовать struct stat к exo::linux::stat."); /* Странно. */
}


stat::stat(const_file file_)
: stat(stat::file(file_))
{}

stat stat::file(const_file file_)
{
    struct ::stat buf;
    int ret = fstat(static_cast<const_file::descriptor_type>(file_), & buf);
    if (ret != 0)
        exception::throw_errno();

    return stat(&buf);
}

stat stat::file(const char * name)
{
    struct ::stat buf;
    int ret = ::stat(name, & buf);
    if (ret != 0)
        exception::throw_errno();

    return stat(&buf);
}

stat stat::link_prefer(const char * name)
{
    struct ::stat buf;
    int ret = lstat(name, & buf);
    if (ret != 0)
        exception::throw_errno();

    return stat(&buf);
}


file::file(const char * path, file_flags flags)
: const_file()
{
    if (is_set(flags, file_flags::creat))
        throw std::invalid_argument("Т.к. указан флаг file_flags::creat, необходимо использовать версию 'void open(const char * path, file_flags flags, file_perm perm)'.");

    flags ^= file_flags::nocloexec;

    int fd_ = open(path,
            static_cast<std::underlying_type<file_flags>::type>(flags));

    if (fd_ < 0)
        exception::throw_errno();

    const_cast<descriptor_type&>(fd) = fd_;
}

file::file(const char * path, file_flags flags, file_perm perm)
: const_file()
{
    flags ^= file_flags::nocloexec;

    int fd_ = open(path,
            static_cast<std::underlying_type<file_flags>::type>(flags),
            static_cast<std::underlying_type<file_perm>::type>(perm));

    if (fd_ < 0)
        exception::throw_errno();

    const_cast<descriptor_type&>(fd) = fd_;
}

void file::close_()
{
    /* Независимо от успешности закрытия, сначала 'освободим' файловый дескриптор:
     * - Если закрытие пройдёт успешно, его всё равно надо будет 'освободить'.
     * - Если не успешен - следует исключить возможность повторного его закрытия в деструкторе.
     * Да и целесообразность его использования после ошибочного закрытия сомнительна - ведь
     * или файловый дескриптор некорректен или у нас ошибка ввода-вывода. */

    descriptor_type _fd = fd;
    release();

    int ret = ::close(_fd);
    if (ret != 0)
        exception::throw_errno();
}


memory_space const_file::read(memory_space buffer) const
{
    ssize_t ret = ::read(fd, buffer.data(), buffer.size());

    if (ret < 0)
        exception::throw_errno();

    return memory_space(buffer.data(), static_cast<size_t>(ret));
}

memory_space const_file::write(memory_space buffer) const
{
    ssize_t ret = ::write(fd, buffer.data(), buffer.size());

    if (ret < 0)
        exception::throw_errno();

    return buffer.remove_prefix(ret);
}

mapping const_file::mmap(map_prot prot, map_type type) const
{
    return mapping(prot, type, *this, 0, stat().size);
}

mapping const_file::mmap(map_prot prot, map_type type, filesize_t offset, filesize_t length) const
{
    return mapping(prot, type, *this, offset, length);
}

mapping const_file::mmap(map_prot prot, map_type type, filesize_t offset, filesize_t length, void * addr) const
{
    return mapping(prot, type, *this, offset, length, addr);
}


#pragma GCC diagnostic push
#pragma GCC diagnostic ignored "-Wold-style-cast"
static const void * map_failed = MAP_FAILED;
#pragma GCC diagnostic pop

mapping::mapping(map_prot prot, map_type type, size_t length)
: area()
{
    if (is_set(type, map_type::fixed))
        throw std::invalid_argument("Т.к. указан флаг fmap_type::fixed, необходимо использовать версию 'mapping(map_prot prot, map_type type, size_t length, void * addr)'.");

    if (is_not_set(type, map_type::anonymous))
        throw std::invalid_argument("Т.к. не указан флаг map_type::anonymous, необходимо использовать версию 'mapping(map_prot prot, map_type type, const_file file, size_t offset, size_t length)'.");

    void * ret = ::mmap(NULL, length,
            static_cast<std::underlying_type<map_prot>::type>(prot),
            static_cast<std::underlying_type<map_type>::type>(type),
            -1, 0);

    if (ret == map_failed)
        exception::throw_errno();

    area = memory_space(ret, length);
}

mapping::mapping(map_prot prot, map_type type, size_t length, void * addr)
: area()
{
    if (is_not_set(type, map_type::anonymous))
        throw std::invalid_argument("Т.к. не указан флаг map_type::anonymous, необходимо использовать версию 'mapping(map_prot prot, map_type type, const_file file, size_t offset, size_t length, void * addr)'.");

    void * ret = ::mmap(addr, length,
            static_cast<std::underlying_type<map_prot>::type>(prot),
            static_cast<std::underlying_type<map_type>::type>(type),
            -1, 0);

    if (ret == map_failed)
        exception::throw_errno();

    area = memory_space(ret, length);
}

mapping::mapping(map_prot prot, map_type type, const_file file, filesize_t offset, size_t length)
: area()
{
    if (is_set(type, map_type::fixed))
        throw std::invalid_argument("Т.к. указан флаг fmap_type::fixed, необходимо использовать версию 'mapping(map_prot prot, map_type type, const_file file, size_t offset, size_t length, void * addr)'.");

#pragma GCC diagnostic push
#pragma GCC diagnostic ignored "-Wsign-conversion"
    void * ret = ::mmap(NULL, length,
            static_cast<std::underlying_type<map_prot>::type>(prot),
            static_cast<std::underlying_type<map_type>::type>(type),
            static_cast<file::descriptor_type>(file),
            offset);
#pragma GCC diagnostic pop

    if (ret == map_failed)
        exception::throw_errno();

    area = memory_space(ret, length);
}

mapping::mapping(map_prot prot, map_type type, const_file file, filesize_t offset, filesize_t length, void * addr)
: area()
{
#pragma GCC diagnostic push
#pragma GCC diagnostic ignored "-Wsign-conversion"
    void * ret = ::mmap(addr, length,
            static_cast<std::underlying_type<map_prot>::type>(prot),
            static_cast<std::underlying_type<map_type>::type>(type),
            static_cast<file::descriptor_type>(file),
            offset);
#pragma GCC diagnostic pop

    if (ret == map_failed)
        exception::throw_errno();

    area = memory_space(ret, length);
}

void mapping::unmap_()
{
    memory_space _area = release();
    int ret = ::munmap(_area.data(), _area.size());
    if (ret != 0)
        exception::throw_errno();
}


} /* namespace linux */
} /* namespace exo */
