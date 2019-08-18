using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3d2c299c-3db0-4a56-b4c0-36d831865d50")]
        public void /* sys */ Method_1017_d4f2()
        {
            ii(0x1017_d4f2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_d4f3, 1); pushd(esi);                             /* push esi */
            ii(0x1017_d4f4, 1); pushd(edi);                             /* push edi */
            ii(0x1017_d4f5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_d4f6, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1017_d4f8, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1017_d4fa, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_d4ff, 2); mov(edi, ebp);                          /* mov edi, ebp */
            ii(0x1017_d501, 2); xor(al, al);                            /* xor al, al */
            ii(0x1017_d503, 1); pushd(es);                              /* push es */
            ii(0x1017_d504, 2); if(jecxzd_func(0x1017_d511, 0xb)) return; /* jecxz 0x1017d511 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
            ii(0x1017_d506, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_d508, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1017_d50a, 2); repne_a32(() => scasb_a32());           /* repne scasb */
            ii(0x1017_d50c, 2); if(jnzd_func(0x1017_d511, 0x3)) return; /* jnz 0x1017d511 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
            ii(0x1017_d50e, 1); dec(edi);                               /* dec edi */
            ii(0x1017_d50f, 4); test(ax, 0xcf89);                       /* test ax, 0xcf89 */
            ii(0x1017_d513, 1); popd(es);                               /* pop es */
            ii(0x1017_d514, 2); mov(eax, edi);                          /* mov eax, edi */
        l_0x1017_d516:
            ii(0x1017_d516, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_d518, 2); if(jzd(0x1017_d527, 0xd)) goto l_0x1017_d527; /* jz 0x1017d527 */
            ii(0x1017_d51a, 2); mov(dl, memb_a32[ds, esi]);             /* mov dl, [esi] */
            ii(0x1017_d51c, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x1017_d51e, 2); test(dl, dl);                           /* test dl, dl */
            ii(0x1017_d520, 2); if(jzd(0x1017_d527, 0x5)) goto l_0x1017_d527; /* jz 0x1017d527 */
            ii(0x1017_d522, 1); inc(eax);                               /* inc eax */
            ii(0x1017_d523, 1); inc(esi);                               /* inc esi */
            ii(0x1017_d524, 1); dec(ebx);                               /* dec ebx */
            ii(0x1017_d525, 2); jmpd(0x1017_d516, -0x11); goto l_0x1017_d516; /* jmp 0x1017d516 */
        l_0x1017_d527:
            ii(0x1017_d527, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
            ii(0x1017_d52a, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_d52c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_d52d, 1); popd(edi);                              /* pop edi */
            ii(0x1017_d52e, 1); popd(esi);                              /* pop esi */
            ii(0x1017_d52f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_d530, 1); retd(); return;                         /* ret */
        }
    }
}
