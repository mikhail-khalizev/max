using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("99104519-06e5-448b-9c8d-9bca0d2365c6")]
        public void Method_1012_abdb()
        {
            ii(0x1012_abdb, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x1012_abe0, 5); calld(Definitions.sys_check_available_stack_size, 0x3_b16d); /* call 0x10165d52 */
            ii(0x1012_abe5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_abe6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_abe7, 1); pushd(edx);                             /* push edx */
            ii(0x1012_abe8, 1); pushd(esi);                             /* push esi */
            ii(0x1012_abe9, 1); pushd(edi);                             /* push edi */
            ii(0x1012_abea, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_abeb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_abed, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1012_abf3, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x25);   /* mov byte [0x101c5c1c], 0x25 */
            ii(0x1012_abfa, 5); mov(eax, memd_a32[ds, 0x101c_59cc]);    /* mov eax, [0x101c59cc] */
            ii(0x1012_abff, 4); mov(ax, memw_a32[ds, eax + 0x14]);      /* mov ax, [eax+0x14] */
            ii(0x1012_ac03, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_ac09, 9); mov(memw_a32[ds, 0x101c_5c1f], 0xad);   /* mov word [0x101c5c1f], 0xad */
            ii(0x1012_ac12, 6); mov(ebx, memd_a32[ds, 0x101c_5c1d]);    /* mov ebx, [0x101c5c1d] */
            ii(0x1012_ac18, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_ac1b, 5); mov(eax, memd_a32[ds, 0x101c_59cc]);    /* mov eax, [0x101c59cc] */
            ii(0x1012_ac20, 6); lea(edx, eax + 0x4f0);                  /* lea edx, [eax+0x4f0] */
            ii(0x1012_ac26, 5); mov(eax, 0x101c_5c21);                  /* mov eax, 0x101c5c21 */
            ii(0x1012_ac2b, 5); calld(Definitions.sys_memcpy, 0x3_b21b); /* call 0x10165e4b */
            ii(0x1012_ac30, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_ac35, 5); calld(0x1012_5be9, -0x5051);            /* call 0x10125be9 */
            ii(0x1012_ac3a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_ac3b, 1); popd(edi);                              /* pop edi */
            ii(0x1012_ac3c, 1); popd(esi);                              /* pop esi */
            ii(0x1012_ac3d, 1); popd(edx);                              /* pop edx */
            ii(0x1012_ac3e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_ac3f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_ac40, 1); retd(); return;                         /* ret */
        }
    }
}
