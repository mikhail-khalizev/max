using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_00bc-32b55b97")]
        public void Method_100a_00bc()
        {
            ii(0x100a_00bc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_00c1, 5); calld(Definitions.sys_check_available_stack_size, 0xc_5c8c); /* call 0x10165d52 */
            ii(0x100a_00c6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_00c7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_00c8, 1); pushd(edx);                             /* push edx */
            ii(0x100a_00c9, 1); pushd(esi);                             /* push esi */
            ii(0x100a_00ca, 1); pushd(edi);                             /* push edi */
            ii(0x100a_00cb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_00cc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_00ce, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_00d4, 5); mov(eax, 0x101b_77b4);                  /* mov eax, 0x101b77b4 */
            ii(0x100a_00d9, 5); calld(/* sys */ 0x1016_611f, 0xc_6041); /* call 0x1016611f */
            ii(0x100a_00de, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_00e3, 5); calld(0x100a_3e9c, 0x3db4);             /* call 0x100a3e9c */
            ii(0x100a_00e8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_00eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_00ee, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_00f1, 10); mov(memd_a32[ds, 0x101b_77bc], 0x1);   /* mov dword [0x101b77bc], 0x1 */
            ii(0x100a_00fb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_00fd, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_00fe, 1); popd(edi);                              /* pop edi */
            ii(0x100a_00ff, 1); popd(esi);                              /* pop esi */
            ii(0x100a_0100, 1); popd(edx);                              /* pop edx */
            ii(0x100a_0101, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_0102, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_0103, 1); retd(); return;                         /* ret */
        }
    }
}
