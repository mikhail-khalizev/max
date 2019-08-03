using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8b0ca704-d5d2-40e4-982c-e1a37d8caf35")]
        public void Method_1015_2387()
        {
            ii(0x1015_2387, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1015_238c, 5); calld(Definitions.sys_check_available_stack_size, 0x139c1); /* call 0x10165d52 */
            ii(0x1015_2391, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_2392, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_2393, 1); pushd(edx);                             /* push edx */
            ii(0x1015_2394, 1); pushd(esi);                             /* push esi */
            ii(0x1015_2395, 1); pushd(edi);                             /* push edi */
            ii(0x1015_2396, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_2397, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2399, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1015_239f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_23a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_23a5, 4); cmp(memb_a32[ds, eax + 0x3d], 0x15);    /* cmp byte [eax+0x3d], 0x15 */
            ii(0x1015_23a9, 2); if(jzd(0x1015_23b4, 0x9)) goto l_0x1015_23b4; /* jz 0x101523b4 */
            ii(0x1015_23ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_23ae, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1f);    /* cmp byte [eax+0x3d], 0x1f */
            ii(0x1015_23b2, 2); if(jnzd(0x1015_23b6, 0x2)) goto l_0x1015_23b6; /* jnz 0x101523b6 */
        l_0x1015_23b4:
            ii(0x1015_23b4, 2); jmpd(0x1015_23d7, 0x21); goto l_0x1015_23d7; /* jmp 0x101523d7 */
        l_0x1015_23b6:
            ii(0x1015_23b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_23b9, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_23bc, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_23be, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_23c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_23c4, 5); calld(0x1015_0a9e, -0x192b);            /* call 0x10150a9e */
            ii(0x1015_23c9, 1); cwde();                                 /* cwde */
            ii(0x1015_23ca, 5); calld(0x100d_4b64, -0x7d86b);           /* call 0x100d4b64 */
            ii(0x1015_23cf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_23d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_23d4, 3); mov(memb_a32[ds, eax + 0x45], dl);      /* mov [eax+0x45], dl */
        l_0x1015_23d7:
            ii(0x1015_23d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_23da, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_23de, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_23e1, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_23e5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_23e7, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1015_23ec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_23ef, 5); calld(0x1016_3053, 0x10c5f);            /* call 0x10163053 */
            ii(0x1015_23f4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_23f6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_23f7, 1); popd(edi);                              /* pop edi */
            ii(0x1015_23f8, 1); popd(esi);                              /* pop esi */
            ii(0x1015_23f9, 1); popd(edx);                              /* pop edx */
            ii(0x1015_23fa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_23fb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_23fc, 1); retd(); return;                         /* ret */
        }
    }
}
