using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_361d-ebeb71e5")]
        public void Method_1012_361d()
        {
            ii(0x1012_361d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_3622, 5); calld(Definitions.sys_check_available_stack_size, 0x4_272b); /* call 0x10165d52 */
            ii(0x1012_3627, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_3628, 1); pushd(esi);                             /* push esi */
            ii(0x1012_3629, 1); pushd(edi);                             /* push edi */
            ii(0x1012_362a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_362b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_362d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_3633, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3636, 7); cmp(memd_a32[ds, eax + 0x84], 0);       /* cmp dword [eax+0x84], 0x0 */
            ii(0x1012_363d, 2); if(jnzd(0x1012_3648, 0x9)) goto l_0x1012_3648; /* jnz 0x10123648 */
            ii(0x1012_363f, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
            ii(0x1012_3646, 2); jmpd(0x1012_36a2, 0x5a); goto l_0x1012_36a2; /* jmp 0x101236a2 */
        l_0x1012_3648:
            ii(0x1012_3648, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_364b, 4); test(memb_a32[ds, eax + 0x1], 0x80);    /* test byte [eax+0x1], 0x80 */
            ii(0x1012_364f, 2); if(jzd(0x1012_369b, 0x4a)) goto l_0x1012_369b; /* jz 0x1012369b */
            ii(0x1012_3651, 2); pushd(0);                               /* push 0x0 */
            ii(0x1012_3653, 5); pushd(0x262);                           /* push 0x262 */
            ii(0x1012_3658, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_365b, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1012_365e, 1); pushd(eax);                             /* push eax */
            ii(0x1012_365f, 5); calld(/* sys */ 0x1017_cf25, 0x5_98c1); /* call 0x1017cf25 */
            ii(0x1012_3664, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1012_3667, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_366a, 4); cmp(memd_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp dword [ebp-0x4], 0xffffffff */
            ii(0x1012_366e, 2); if(jnzd(0x1012_3679, 0x9)) goto l_0x1012_3679; /* jnz 0x10123679 */
            ii(0x1012_3670, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_3677, 2); jmpd(0x1012_36a2, 0x29); goto l_0x1012_36a2; /* jmp 0x101236a2 */
        l_0x1012_3679:
            ii(0x1012_3679, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_367c, 6); mov(ebx, memd_a32[ds, eax + 0x88]);     /* mov ebx, [eax+0x88] */
            ii(0x1012_3682, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3685, 6); mov(edx, memd_a32[ds, eax + 0x84]);     /* mov edx, [eax+0x84] */
            ii(0x1012_368b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_368e, 5); calld(/* sys */ 0x1017_d2f5, 0x5_9c62); /* call 0x1017d2f5 */
            ii(0x1012_3693, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_3696, 5); calld(/* sys */ 0x1017_d1da, 0x5_9b3f); /* call 0x1017d1da */
        l_0x1012_369b:
            ii(0x1012_369b, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
        l_0x1012_36a2:
            ii(0x1012_36a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_36a5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_36a7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_36a8, 1); popd(edi);                              /* pop edi */
            ii(0x1012_36a9, 1); popd(esi);                              /* pop esi */
            ii(0x1012_36aa, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_36ab, 1); retd(); return;                         /* ret */
        }
    }
}
