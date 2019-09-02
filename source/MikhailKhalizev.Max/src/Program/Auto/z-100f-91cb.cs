using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_91cb-aeb1e654")]
        public void Method_100f_91cb()
        {
            ii(0x100f_91cb, 5); push(0x24);                             /* push 0x24 */
            ii(0x100f_91d0, 5); call(Definitions.sys_check_available_stack_size, 0x6_cb7d); /* call 0x10165d52 */
            ii(0x100f_91d5, 1); push(ebx);                              /* push ebx */
            ii(0x100f_91d6, 1); push(ecx);                              /* push ecx */
            ii(0x100f_91d7, 1); push(esi);                              /* push esi */
            ii(0x100f_91d8, 1); push(edi);                              /* push edi */
            ii(0x100f_91d9, 1); push(ebp);                              /* push ebp */
            ii(0x100f_91da, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_91dc, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100f_91e2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_91e5, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100f_91e8, 5); call(0x1007_6034, -0x8_31b9);           /* call 0x10076034 */
            ii(0x100f_91ed, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_91ef, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_91f1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_91f4, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100f_91f7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_91fa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_91fd, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100f_9200, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9203, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_9206, 5); call(0x1007_4c30, -0x8_45db);           /* call 0x10074c30 */
            ii(0x100f_920b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100f_920e, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100f_9212, 2); if(jz(0x100f_9273, 0x5f)) goto l_0x100f_9273; /* jz 0x100f9273 */
            ii(0x100f_9214, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_9217, 3); mov(al, memb[ds, eax + 0x50]);          /* mov al, [eax+0x50] */
            ii(0x100f_921a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_921f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_9221, 2); if(jnz(0x100f_9245, 0x22)) goto l_0x100f_9245; /* jnz 0x100f9245 */
            ii(0x100f_9223, 5); call(0x100c_aa00, -0x2_e828);           /* call 0x100caa00 */
            ii(0x100f_9228, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_922d, 1); push(eax);                              /* push eax */
            ii(0x100f_922e, 5); call(0x100c_aa20, -0x2_e813);           /* call 0x100caa20 */
            ii(0x100f_9233, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_9235, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_9237, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_9239, 5); mov(eax, StringDefinitions.InfiltratorHasAlreadyUsedHisActionThisTurnTryAgainNextTurn2); /* mov eax, 0x101a2830 */
            ii(0x100f_923e, 5); call(0x1011_5d23, 0x1_cae0);            /* call 0x10115d23 */
            ii(0x100f_9243, 2); jmp(0x100f_9273, 0x2e); goto l_0x100f_9273; /* jmp 0x100f9273 */
        l_0x100f_9245:
            ii(0x100f_9245, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100f_9248, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_924b, 5); call(0x1008_a998, -0x6_e8b8);           /* call 0x1008a998 */
            ii(0x100f_9250, 5); call(/* sys */ 0x1016_5e9b, 0x6_cc46);  /* call 0x10165e9b */
            ii(0x100f_9255, 3); imul(eax, eax, 0x65);                   /* imul eax, eax, 0x65 */
            ii(0x100f_9258, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_925b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_925d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_9260, 4); mov(memw[ds, eax + 0x41], dx);          /* mov [eax+0x41], dx */
            ii(0x100f_9264, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_9266, 5); mov(edx, 0x19);                         /* mov edx, 0x19 */
            ii(0x100f_926b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_926e, 5); call(0x1016_3053, 0x6_9de0);            /* call 0x10163053 */
        l_0x100f_9273:
            ii(0x100f_9273, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_9275, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_9276, 1); pop(edi);                               /* pop edi */
            ii(0x100f_9277, 1); pop(esi);                               /* pop esi */
            ii(0x100f_9278, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_9279, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_927a, 1); ret();                                  /* ret */
        }
    }
}
