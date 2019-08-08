using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5d2bdd38-c12d-4ae5-8ead-f9c988e43b14")]
        public void Method_100a_25e5()
        {
            ii(0x100a_25e5, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_25ea, 5); calld(Definitions.sys_check_available_stack_size, 0xc_3763); /* call 0x10165d52 */
            ii(0x100a_25ef, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_25f0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_25f1, 1); pushd(edx);                             /* push edx */
            ii(0x100a_25f2, 1); pushd(esi);                             /* push esi */
            ii(0x100a_25f3, 1); pushd(edi);                             /* push edi */
            ii(0x100a_25f4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_25f5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_25f7, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_25fd, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x100a_2600:
            ii(0x100a_2600, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100a_2606, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_2609, 5); calld(/* sys */ 0x1016_5e9b, 0xc_388d); /* call 0x10165e9b */
            ii(0x100a_260e, 3); sub(edx, 0x6);                          /* sub edx, 0x6 */
            ii(0x100a_2611, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100a_2614, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100a_2617, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100a_261a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_261d, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100a_2623, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_2626, 5); calld(/* sys */ 0x1016_5e9b, 0xc_3870); /* call 0x10165e9b */
            ii(0x100a_262b, 3); sub(edx, 0x6);                          /* sub edx, 0x6 */
            ii(0x100a_262e, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100a_2631, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100a_2634, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100a_2637, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_263a, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100a_263e, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100a_2642, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100a_2646, 5); calld(0x100a_24e3, -0x168);             /* call 0x100a24e3 */
            ii(0x100a_264b, 2); test(al, al);                           /* test al, al */
            ii(0x100a_264d, 2); if(jzd(0x100a_2600, -0x4f)) goto l_0x100a_2600; /* jz 0x100a2600 */
            ii(0x100a_264f, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100a_2653, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100a_2656, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_2659, 7); mov(memw_a32[ds, edx + 0x101c_35bc], ax); /* mov [edx+0x101c35bc], ax */
            ii(0x100a_2660, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100a_2664, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100a_2667, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_266a, 7); mov(memw_a32[ds, edx + 0x101c_35be], ax); /* mov [edx+0x101c35be], ax */
            ii(0x100a_2671, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2673, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2674, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2675, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2676, 1); popd(edx);                              /* pop edx */
            ii(0x100a_2677, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2678, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2679, 1); retd(); return;                         /* ret */
        }
    }
}
