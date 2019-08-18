using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_99cc-27f7c3fa")]
        public void Method_1015_99cc()
        {
            ii(0x1015_99cc, 5); pushd(0x3e0);                           /* push 0x3e0 */
            ii(0x1015_99d1, 5); calld(Definitions.sys_check_available_stack_size, 0xc37c); /* call 0x10165d52 */
            ii(0x1015_99d6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_99d7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_99d8, 1); pushd(esi);                             /* push esi */
            ii(0x1015_99d9, 1); pushd(edi);                             /* push edi */
            ii(0x1015_99da, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_99db, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_99dd, 6); sub(esp, 0x3c8);                        /* sub esp, 0x3c8 */
            ii(0x1015_99e3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_99e6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_99e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_99ec, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_99ef, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_99f4, 5); calld(0x100f_448c, -0x6_556d);          /* call 0x100f448c */
            ii(0x1015_99f9, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1015_99fd, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_9a00, 5); calld(0x1007_6204, -0xe_3801);          /* call 0x10076204 */
            ii(0x1015_9a05, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_9a07, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_9a0a, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_9a0d, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_9a0f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_9a12, 6); lea(eax, ebp - 0x3c8);                  /* lea eax, [ebp-0x3c8] */
            ii(0x1015_9a18, 5); calld(0x100d_b2ee, -0x7_e72f);          /* call 0x100db2ee */
            ii(0x1015_9a1d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_9a20, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1015_9a24, 6); lea(eax, ebp - 0x3c8);                  /* lea eax, [ebp-0x3c8] */
            ii(0x1015_9a2a, 5); calld(0x100d_b229, -0x7_e806);          /* call 0x100db229 */
            ii(0x1015_9a2f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9a31, 6); lea(eax, ebp - 0x3c8);                  /* lea eax, [ebp-0x3c8] */
            ii(0x1015_9a37, 5); calld(0x100d_bc47, -0x7_ddf5);          /* call 0x100dbc47 */
            ii(0x1015_9a3c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9a3e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_9a3f, 1); popd(edi);                              /* pop edi */
            ii(0x1015_9a40, 1); popd(esi);                              /* pop esi */
            ii(0x1015_9a41, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_9a42, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_9a43, 1); retd(); return;                         /* ret */
        }
    }
}
