using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8ffa-3130b423")]
        public void Method_100b_8ffa()
        {
            ii(0x100b_8ffa, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_8fff, 5); calld(Definitions.sys_check_available_stack_size, 0xa_cd4e); /* call 0x10165d52 */
            ii(0x100b_9004, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_9005, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_9006, 1); pushd(edx);                             /* push edx */
            ii(0x100b_9007, 1); pushd(esi);                             /* push esi */
            ii(0x100b_9008, 1); pushd(edi);                             /* push edi */
            ii(0x100b_9009, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_900a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_900c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_9012, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9015, 5); cmp(memw_a32[ss, ebp - 0x4], 0x41);     /* cmp word [ebp-0x4], 0x41 */
            ii(0x100b_901a, 2); if(jnzd(0x100b_9022, 0x6)) goto l_0x100b_9022; /* jnz 0x100b9022 */
            ii(0x100b_901c, 4); mov(memb_a32[ss, ebp - 0x8], 0x7);      /* mov byte [ebp-0x8], 0x7 */
            ii(0x100b_9020, 2); jmpd(0x100b_9063, 0x41); goto l_0x100b_9063; /* jmp 0x100b9063 */
        l_0x100b_9022:
            ii(0x100b_9022, 5); cmp(memw_a32[ss, ebp - 0x4], 0x47);     /* cmp word [ebp-0x4], 0x47 */
            ii(0x100b_9027, 2); if(jnzd(0x100b_902f, 0x6)) goto l_0x100b_902f; /* jnz 0x100b902f */
            ii(0x100b_9029, 4); mov(memb_a32[ss, ebp - 0x8], 0x6);      /* mov byte [ebp-0x8], 0x6 */
            ii(0x100b_902d, 2); jmpd(0x100b_9063, 0x34); goto l_0x100b_9063; /* jmp 0x100b9063 */
        l_0x100b_902f:
            ii(0x100b_902f, 5); cmp(memw_a32[ss, ebp - 0x4], 0x42);     /* cmp word [ebp-0x4], 0x42 */
            ii(0x100b_9034, 2); if(jnzd(0x100b_903c, 0x6)) goto l_0x100b_903c; /* jnz 0x100b903c */
            ii(0x100b_9036, 4); mov(memb_a32[ss, ebp - 0x8], 0x5);      /* mov byte [ebp-0x8], 0x5 */
            ii(0x100b_903a, 2); jmpd(0x100b_9063, 0x27); goto l_0x100b_9063; /* jmp 0x100b9063 */
        l_0x100b_903c:
            ii(0x100b_903c, 5); cmp(memw_a32[ss, ebp - 0x4], 0x39);     /* cmp word [ebp-0x4], 0x39 */
            ii(0x100b_9041, 2); if(jnzd(0x100b_9049, 0x6)) goto l_0x100b_9049; /* jnz 0x100b9049 */
            ii(0x100b_9043, 4); mov(memb_a32[ss, ebp - 0x8], 0x2);      /* mov byte [ebp-0x8], 0x2 */
            ii(0x100b_9047, 2); jmpd(0x100b_9063, 0x1a); goto l_0x100b_9063; /* jmp 0x100b9063 */
        l_0x100b_9049:
            ii(0x100b_9049, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100b_904d, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100b_9050, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x40); /* test byte [eax+0x101c81c0], 0x40 */
            ii(0x100b_9057, 2); if(jzd(0x100b_905f, 0x6)) goto l_0x100b_905f; /* jz 0x100b905f */
            ii(0x100b_9059, 4); mov(memb_a32[ss, ebp - 0x8], 0x3);      /* mov byte [ebp-0x8], 0x3 */
            ii(0x100b_905d, 2); jmpd(0x100b_9063, 0x4); goto l_0x100b_9063; /* jmp 0x100b9063 */
        l_0x100b_905f:
            ii(0x100b_905f, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100b_9063:
            ii(0x100b_9063, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_9066, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_9068, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_9069, 1); popd(edi);                              /* pop edi */
            ii(0x100b_906a, 1); popd(esi);                              /* pop esi */
            ii(0x100b_906b, 1); popd(edx);                              /* pop edx */
            ii(0x100b_906c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_906d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_906e, 1); retd(); return;                         /* ret */
        }
    }
}
