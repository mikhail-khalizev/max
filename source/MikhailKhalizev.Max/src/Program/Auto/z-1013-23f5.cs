using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45b933ac-5e7b-4382-aa87-17aeac531fcf")]
        public void Method_1013_23f5()
        {
            ii(0x1013_23f5, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1013_23fa, 5); calld(Definitions.sys_check_available_stack_size, 0x3_3953); /* call 0x10165d52 */
            ii(0x1013_23ff, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_2400, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_2401, 1); pushd(edx);                             /* push edx */
            ii(0x1013_2402, 1); pushd(esi);                             /* push esi */
            ii(0x1013_2403, 1); pushd(edi);                             /* push edi */
            ii(0x1013_2404, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_2405, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_2407, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_240d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_2410, 5); calld(0x100d_51e4, -0x5_d231);          /* call 0x100d51e4 */
            ii(0x1013_2415, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_241a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_241d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_2420, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_2422, 5); calld(0x1013_3964, 0x153d);             /* call 0x10133964 */
            ii(0x1013_2427, 1); cwde();                                 /* cwde */
            ii(0x1013_2428, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_242a, 2); if(jled(0x1013_2432, 0x6)) goto l_0x1013_2432; /* jle 0x10132432 */
            ii(0x1013_242c, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1013_2430, 2); jmpd(0x1013_2436, 0x4); goto l_0x1013_2436; /* jmp 0x10132436 */
        l_0x1013_2432:
            ii(0x1013_2432, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1013_2436:
            ii(0x1013_2436, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2438, 3); mov(dl, memb_a32[ss, ebp - 0xc]);       /* mov dl, [ebp-0xc] */
            ii(0x1013_243b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_243e, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1013_2441, 3); mov(ebx, memd_a32[ss, ebp - 0x14]);     /* mov ebx, [ebp-0x14] */
            ii(0x1013_2444, 5); calld(0x100c_fa7c, -0x6_29cd);          /* call 0x100cfa7c */
            ii(0x1013_2449, 5); calld(0x100d_51e4, -0x5_d26a);          /* call 0x100d51e4 */
            ii(0x1013_244e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_2453, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_2456, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_2459, 3); mov(eax, memd_a32[ds, eax + 0x3]);      /* mov eax, [eax+0x3] */
            ii(0x1013_245c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_245f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_2461, 2); if(jled(0x1013_2469, 0x6)) goto l_0x1013_2469; /* jle 0x10132469 */
            ii(0x1013_2463, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1013_2467, 2); jmpd(0x1013_246d, 0x4); goto l_0x1013_246d; /* jmp 0x1013246d */
        l_0x1013_2469:
            ii(0x1013_2469, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1013_246d:
            ii(0x1013_246d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_246f, 3); mov(dl, memb_a32[ss, ebp - 0x8]);       /* mov dl, [ebp-0x8] */
            ii(0x1013_2472, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_2475, 3); mov(eax, memd_a32[ds, eax + 0xb]);      /* mov eax, [eax+0xb] */
            ii(0x1013_2478, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1013_247b, 5); calld(0x100c_fa7c, -0x6_2a04);          /* call 0x100cfa7c */
            ii(0x1013_2480, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_2482, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_2483, 1); popd(edi);                              /* pop edi */
            ii(0x1013_2484, 1); popd(esi);                              /* pop esi */
            ii(0x1013_2485, 1); popd(edx);                              /* pop edx */
            ii(0x1013_2486, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_2487, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_2488, 1); retd(); return;                         /* ret */
        }
    }
}
