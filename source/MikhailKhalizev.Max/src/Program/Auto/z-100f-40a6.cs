using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("944c3ff6-7bc3-4890-91f9-3f0aebceb201")]
        public void Method_100f_40a6()
        {
            ii(0x100f_40a6, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x100f_40ab, 5); calld(Definitions.sys_check_available_stack_size, 0x7_1ca2); /* call 0x10165d52 */
            ii(0x100f_40b0, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_40b1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_40b2, 1); pushd(edx);                             /* push edx */
            ii(0x100f_40b3, 1); pushd(esi);                             /* push esi */
            ii(0x100f_40b4, 1); pushd(edi);                             /* push edi */
            ii(0x100f_40b5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_40b6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_40b8, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x100f_40be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_40c0, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_40c5, 5); calld(0x1013_ad71, 0x4_6ca7);           /* call 0x1013ad71 */
            ii(0x100f_40ca, 2); test(al, al);                           /* test al, al */
            ii(0x100f_40cc, 2); if(jzd(0x100f_40de, 0x10)) goto l_0x100f_40de; /* jz 0x100f40de */
            ii(0x100f_40ce, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_40d3, 5); calld(0x1007_6574, -0x7_db64);          /* call 0x10076574 */
            ii(0x100f_40d8, 4); cmp(memb_a32[ds, eax + 0x3e], 0x19);    /* cmp byte [eax+0x3e], 0x19 */
            ii(0x100f_40dc, 2); if(jzd(0x100f_40e0, 0x2)) goto l_0x100f_40e0; /* jz 0x100f40e0 */
        l_0x100f_40de:
            ii(0x100f_40de, 2); jmpd(0x100f_40ef, 0xf); goto l_0x100f_40ef; /* jmp 0x100f40ef */
        l_0x100f_40e0:
            ii(0x100f_40e0, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_40e5, 5); calld(0x1007_6600, -0x7_daea);          /* call 0x10076600 */
            ii(0x100f_40ea, 5); calld(0x100f_3f62, -0x18d);             /* call 0x100f3f62 */
        l_0x100f_40ef:
            ii(0x100f_40ef, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_40f0, 1); popd(edi);                              /* pop edi */
            ii(0x100f_40f1, 1); popd(esi);                              /* pop esi */
            ii(0x100f_40f2, 1); popd(edx);                              /* pop edx */
            ii(0x100f_40f3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_40f4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_40f5, 1); retd(); return;                         /* ret */
        }
    }
}
