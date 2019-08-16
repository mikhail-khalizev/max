using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("282a5555-1d9e-40d2-bfc2-347c5d9b0caf")]
        public void Method_1013_31d0()
        {
            ii(0x1013_31d0, 5); pushd(0x14c);                           /* push 0x14c */
            ii(0x1013_31d5, 5); calld(Definitions.sys_check_available_stack_size, 0x3_2b78); /* call 0x10165d52 */
            ii(0x1013_31da, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_31db, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_31dc, 1); pushd(edx);                             /* push edx */
            ii(0x1013_31dd, 1); pushd(esi);                             /* push esi */
            ii(0x1013_31de, 1); pushd(edi);                             /* push edi */
            ii(0x1013_31df, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_31e0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_31e2, 6); sub(esp, 0x130);                        /* sub esp, 0x130 */
            ii(0x1013_31e8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_31eb, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1013_31ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_31f2, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1013_31f5, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1013_31f7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_31fa, 6); lea(eax, ebp - 0x130);                  /* lea eax, [ebp-0x130] */
            ii(0x1013_3200, 5); calld(0x1013_28d2, -0x933);             /* call 0x101328d2 */
            ii(0x1013_3205, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_3208, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1013_320c, 6); lea(eax, ebp - 0x130);                  /* lea eax, [ebp-0x130] */
            ii(0x1013_3212, 5); calld(0x1013_2f1a, -0x2fd);             /* call 0x10132f1a */
            ii(0x1013_3217, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_3219, 6); lea(eax, ebp - 0x130);                  /* lea eax, [ebp-0x130] */
            ii(0x1013_321f, 5); calld(0x1013_2d9a, -0x48a);             /* call 0x10132d9a */
            ii(0x1013_3224, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3226, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_3227, 1); popd(edi);                              /* pop edi */
            ii(0x1013_3228, 1); popd(esi);                              /* pop esi */
            ii(0x1013_3229, 1); popd(edx);                              /* pop edx */
            ii(0x1013_322a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_322b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_322c, 1); retd(); return;                         /* ret */
        }
    }
}