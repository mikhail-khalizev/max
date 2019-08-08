using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0fafe0b9-7997-405e-b46a-978bd072280d")]
        public void Method_100f_f5c1()
        {
            ii(0x100f_f5c1, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100f_f5c6, 5); calld(Definitions.sys_check_available_stack_size, 0x6_6787); /* call 0x10165d52 */
            ii(0x100f_f5cb, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_f5cc, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_f5cd, 1); pushd(edx);                             /* push edx */
            ii(0x100f_f5ce, 1); pushd(esi);                             /* push esi */
            ii(0x100f_f5cf, 1); pushd(edi);                             /* push edi */
            ii(0x100f_f5d0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_f5d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_f5d3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_f5d9, 5); calld(0x100e_809e, -0x1_7540);          /* call 0x100e809e */
            ii(0x100f_f5de, 6); mov(ax, memw_a32[ds, 0x101c_38f8]);     /* mov ax, [0x101c38f8] */
            ii(0x100f_f5e4, 1); inc(eax);                               /* inc eax */
            ii(0x100f_f5e5, 1); cwde();                                 /* cwde */
            ii(0x100f_f5e6, 1); pushd(eax);                             /* push eax */
            ii(0x100f_f5e7, 6); mov(ax, memw_a32[ds, 0x101c_38f4]);     /* mov ax, [0x101c38f4] */
            ii(0x100f_f5ed, 1); inc(eax);                               /* inc eax */
            ii(0x100f_f5ee, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_f5f1, 6); mov(ebx, memd_a32[ds, 0x101c_38ee]);    /* mov ebx, [0x101c38ee] */
            ii(0x100f_f5f7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_f5fa, 6); mov(edx, memd_a32[ds, 0x101c_38ea]);    /* mov edx, [0x101c38ea] */
            ii(0x100f_f600, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_f603, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_f606, 5); calld(0x1008_b148, -0x7_44c3);          /* call 0x1008b148 */
            ii(0x100f_f60b, 7); mov(memb_a32[ds, 0x101c_391c], 0x1);    /* mov byte [0x101c391c], 0x1 */
            ii(0x100f_f612, 5); mov(al, memb_a32[ds, 0x101c_391c]);     /* mov al, [0x101c391c] */
            ii(0x100f_f617, 5); mov(memb_a32[ds, 0x101c_391b], al);     /* mov [0x101c391b], al */
            ii(0x100f_f61c, 5); mov(al, memb_a32[ds, 0x101c_391b]);     /* mov al, [0x101c391b] */
            ii(0x100f_f621, 5); mov(memb_a32[ds, 0x101c_391a], al);     /* mov [0x101c391a], al */
            ii(0x100f_f626, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100f_f629, 5); calld(0x100e_4f96, -0x1_a698);          /* call 0x100e4f96 */
            ii(0x100f_f62e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_f630, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_f631, 1); popd(edi);                              /* pop edi */
            ii(0x100f_f632, 1); popd(esi);                              /* pop esi */
            ii(0x100f_f633, 1); popd(edx);                              /* pop edx */
            ii(0x100f_f634, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_f635, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_f636, 1); retd(); return;                         /* ret */
        }
    }
}
