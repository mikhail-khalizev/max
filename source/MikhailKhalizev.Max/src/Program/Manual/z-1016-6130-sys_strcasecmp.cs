using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_6130-63cf5e5f")]
        public void /* sys */ sys_strcasecmp()
        {
            var s1 = Memory.ReadCString(ds[eax]);
            var s2 = Memory.ReadCString(ds[edx]);
            eax = StringComparer.OrdinalIgnoreCase.Compare(s1, s2);
            ret();
            return;

#if false
            ii(0x1016_6130, 1); push(ebx);                              /* push ebx */
            ii(0x1016_6131, 1); push(ecx);                              /* push ecx */
            ii(0x1016_6132, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1016_6134:
            ii(0x1016_6134, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1016_6136, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_6138, 2); mov(ah, memb[ds, edx]);                 /* mov ah, [edx] */
            ii(0x1016_613a, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_613c, 3); cmp(ecx, 0x41);                         /* cmp ecx, 0x41 */
            ii(0x1016_613f, 2); if(jl(0x1016_6148, 0x7)) goto l_0x1016_6148; /* jl 0x10166148 */
            ii(0x1016_6141, 3); cmp(ecx, 0x5a);                         /* cmp ecx, 0x5a */
            ii(0x1016_6144, 2); if(jg(0x1016_6148, 0x2)) goto l_0x1016_6148; /* jg 0x10166148 */
            ii(0x1016_6146, 2); add(al, 0x20);                          /* add al, 0x20 */
        l_0x1016_6148:
            ii(0x1016_6148, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_614a, 2); mov(cl, ah);                            /* mov cl, ah */
            ii(0x1016_614c, 3); cmp(ecx, 0x41);                         /* cmp ecx, 0x41 */
            ii(0x1016_614f, 2); if(jl(0x1016_6159, 0x8)) goto l_0x1016_6159; /* jl 0x10166159 */
            ii(0x1016_6151, 3); cmp(ecx, 0x5a);                         /* cmp ecx, 0x5a */
            ii(0x1016_6154, 2); if(jg(0x1016_6159, 0x3)) goto l_0x1016_6159; /* jg 0x10166159 */
            ii(0x1016_6156, 3); add(ah, 0x20);                          /* add ah, 0x20 */
        l_0x1016_6159:
            ii(0x1016_6159, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1016_615b, 2); if(jnz(0x1016_6165, 0x8)) goto l_0x1016_6165; /* jnz 0x10166165 */
            ii(0x1016_615d, 2); test(ah, ah);                           /* test ah, ah */
            ii(0x1016_615f, 2); if(jz(0x1016_6165, 0x4)) goto l_0x1016_6165; /* jz 0x10166165 */
            ii(0x1016_6161, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_6162, 1); inc(edx);                               /* inc edx */
            ii(0x1016_6163, 2); jmp(0x1016_6134, -0x31); goto l_0x1016_6134; /* jmp 0x10166134 */
        l_0x1016_6165:
            ii(0x1016_6165, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_6167, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_6169, 2); mov(al, ah);                            /* mov al, ah */
            ii(0x1016_616b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_6170, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_6172, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_6174, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_6175, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_6176, 1); ret();                                  /* ret */
#endif
        }
    }
}
