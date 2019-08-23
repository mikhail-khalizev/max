using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_2fc1-6029c0cd")]
        public void Method_100c_2fc1()
        {
            ii(0x100c_2fc1, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100c_2fc6, 5); calld(Definitions.sys_check_available_stack_size, 0xa_2d87); /* call 0x10165d52 */
            ii(0x100c_2fcb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_2fcc, 1); pushd(esi);                             /* push esi */
            ii(0x100c_2fcd, 1); pushd(edi);                             /* push edi */
            ii(0x100c_2fce, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_2fcf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_2fd1, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100c_2fd7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_2fda, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_2fdd, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_2fe0, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100c_2fe4, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_2fe7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_2fea, 5); calld(0x1007_5e64, -0x4_d18b);          /* call 0x10075e64 */
            ii(0x100c_2fef, 3); lea(ecx, ebp - 0x24);                   /* lea ecx, [ebp-0x24] */
            ii(0x100c_2ff2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_2ff4, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100c_2ff6, 5); calld(0x100a_95c1, -0x1_9a3a);          /* call 0x100a95c1 */
        l_0x100c_2ffb:
            ii(0x100c_2ffb, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100c_2ffe, 5); calld(0x1008_982c, -0x3_97d7);          /* call 0x1008982c */
            ii(0x100c_3003, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_3006, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100c_3009, 5); calld(0x1008_9860, -0x3_97ae);          /* call 0x10089860 */
            ii(0x100c_300e, 1); cwde();                                 /* cwde */
            ii(0x100c_300f, 5); calld(0x1007_3d48, -0x4_f2cc);          /* call 0x10073d48 */
            ii(0x100c_3014, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100c_3018, 2); if(jnzd(0x100c_3020, 0x6)) goto l_0x100c_3020; /* jnz 0x100c3020 */
            ii(0x100c_301a, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100c_301e, 2); jmpd(0x100c_3030, 0x10); goto l_0x100c_3030; /* jmp 0x100c3030 */
        l_0x100c_3020:
            ii(0x100c_3020, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100c_3023, 5); calld(0x100a_96db, -0x1_994d);          /* call 0x100a96db */
            ii(0x100c_3028, 2); test(al, al);                           /* test al, al */
            ii(0x100c_302a, 2); if(jnzd(0x100c_2ffb, -0x31)) goto l_0x100c_2ffb; /* jnz 0x100c2ffb */
            ii(0x100c_302c, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x100c_3030:
            ii(0x100c_3030, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100c_3033, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_3035, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_3036, 1); popd(edi);                              /* pop edi */
            ii(0x100c_3037, 1); popd(esi);                              /* pop esi */
            ii(0x100c_3038, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_3039, 1); retd();                                 /* ret */
        }
    }
}
