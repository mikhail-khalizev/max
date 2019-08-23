using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_a9e3-a3c2bb03")]
        public void Method_1012_a9e3()
        {
            ii(0x1012_a9e3, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x1012_a9e8, 5); calld(Definitions.sys_check_available_stack_size, 0x3_b365); /* call 0x10165d52 */
            ii(0x1012_a9ed, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_a9ee, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_a9ef, 1); pushd(edx);                             /* push edx */
            ii(0x1012_a9f0, 1); pushd(esi);                             /* push esi */
            ii(0x1012_a9f1, 1); pushd(edi);                             /* push edi */
            ii(0x1012_a9f2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_a9f3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_a9f5, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1012_a9fb, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x24);   /* mov byte [0x101c5c1c], 0x24 */
            ii(0x1012_aa02, 5); mov(eax, memd_a32[ds, 0x101c_59cc]);    /* mov eax, [0x101c59cc] */
            ii(0x1012_aa07, 4); mov(ax, memw_a32[ds, eax + 0x14]);      /* mov ax, [eax+0x14] */
            ii(0x1012_aa0b, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_aa11, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x1e);   /* mov word [0x101c5c1f], 0x1e */
            ii(0x1012_aa1a, 5); mov(eax, memd_a32[ds, 0x101c_59cc]);    /* mov eax, [0x101c59cc] */
            ii(0x1012_aa1f, 6); lea(edx, eax + 0x21a);                  /* lea edx, [eax+0x21a] */
            ii(0x1012_aa25, 5); mov(eax, 0x101c_5c21);                  /* mov eax, 0x101c5c21 */
            ii(0x1012_aa2a, 5); calld(Definitions.sys_strcpy, 0x3_b4a0); /* call 0x10165ecf */
            ii(0x1012_aa2f, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_aa34, 5); calld(0x1012_5be9, -0x4e50);            /* call 0x10125be9 */
            ii(0x1012_aa39, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_aa3a, 1); popd(edi);                              /* pop edi */
            ii(0x1012_aa3b, 1); popd(esi);                              /* pop esi */
            ii(0x1012_aa3c, 1); popd(edx);                              /* pop edx */
            ii(0x1012_aa3d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_aa3e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_aa3f, 1); retd();                                 /* ret */
        }
    }
}
