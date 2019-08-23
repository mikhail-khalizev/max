using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_f3a0-387f1a9c")]
        public void Method_100e_f3a0()
        {
            ii(0x100e_f3a0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_f3a5, 5); calld(Definitions.sys_check_available_stack_size, 0x7_69a8); /* call 0x10165d52 */
            ii(0x100e_f3aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_f3ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_f3ac, 1); pushd(edx);                             /* push edx */
            ii(0x100e_f3ad, 1); pushd(esi);                             /* push esi */
            ii(0x100e_f3ae, 1); pushd(edi);                             /* push edi */
            ii(0x100e_f3af, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_f3b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_f3b2, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_f3b8, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100e_f3bb, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_f3c0, 5); calld(0x1013_d08a, 0x4_dcc5);           /* call 0x1013d08a */
            ii(0x100e_f3c5, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_f3c9, 2); if(jzd(0x100e_f3d1, 0x6)) goto l_0x100e_f3d1; /* jz 0x100ef3d1 */
            ii(0x100e_f3cb, 4); cmp(memb_a32[ss, ebp - 0x4], 0x1);      /* cmp byte [ebp-0x4], 0x1 */
            ii(0x100e_f3cf, 2); if(jnzd(0x100e_f3d6, 0x5)) goto l_0x100e_f3d6; /* jnz 0x100ef3d6 */
        l_0x100e_f3d1:
            ii(0x100e_f3d1, 5); calld(0x1011_7e14, 0x2_8a3e);           /* call 0x10117e14 */
        l_0x100e_f3d6:
            ii(0x100e_f3d6, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_f3db, 5); calld(0x1013_cd6c, 0x4_d98c);           /* call 0x1013cd6c */
            ii(0x100e_f3e0, 5); calld(0x1014_8507, 0x5_9122);           /* call 0x10148507 */
            ii(0x100e_f3e5, 5); calld(/* sys */ 0x1016_66b0, 0x7_72c6); /* call 0x101666b0 */
            ii(0x100e_f3ea, 5); calld(/* sys */ 0x1017_1880, 0x8_2491); /* call 0x10171880 */
            ii(0x100e_f3ef, 5); calld(0x1010_826e, 0x1_8e7a);           /* call 0x1010826e */
            ii(0x100e_f3f4, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x100e_f3f8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_f3fb, 6); pushd(memd_a32[ds, eax + 0x101b_868c]); /* push dword [eax+0x101b868c] */
            ii(0x100e_f401, 5); mov(eax, StringDefinitions.S2);         /* mov eax, 0x101a201c */
            ii(0x100e_f406, 1); pushd(eax);                             /* push eax */
            ii(0x100e_f407, 5); calld(Definitions.sys_printf, 0x7_d230); /* call 0x1016c63c */
            ii(0x100e_f40c, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x100e_f40f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_f411, 5); calld(Definitions.sys_exit, 0x7_d249);  /* call 0x1016c65f */
            ii(0x100e_f416, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_f418, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_f419, 1); popd(edi);                              /* pop edi */
            ii(0x100e_f41a, 1); popd(esi);                              /* pop esi */
            ii(0x100e_f41b, 1); popd(edx);                              /* pop edx */
            ii(0x100e_f41c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_f41d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_f41e, 1); retd();                                 /* ret */
        }
    }
}
