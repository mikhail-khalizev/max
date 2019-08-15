using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1d0610ca-16d6-4c81-96e7-a731339f8ed4")]
        public void Method_100a_9d82()
        {
            ii(0x100a_9d82, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_9d87, 5); calld(Definitions.sys_check_available_stack_size, 0xb_bfc6); /* call 0x10165d52 */
            ii(0x100a_9d8c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_9d8d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_9d8e, 1); pushd(edx);                             /* push edx */
            ii(0x100a_9d8f, 1); pushd(esi);                             /* push esi */
            ii(0x100a_9d90, 1); pushd(edi);                             /* push edi */
            ii(0x100a_9d91, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_9d92, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9d94, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_9d9a, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_9d9f, 5); calld(0x100a_3f3f, -0x5e65);            /* call 0x100a3f3f */
            ii(0x100a_9da4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_9da7, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100a_9dae, 2); jmpd(0x100a_9db6, 0x6); goto l_0x100a_9db6; /* jmp 0x100a9db6 */
        l_0x100a_9db0:
            ii(0x100a_9db0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9db3, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x100a_9db6:
            ii(0x100a_9db6, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_9dba, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100a_9dbd, 2); if(jged(0x100a_9df4, 0x35)) goto l_0x100a_9df4; /* jge 0x100a9df4 */
            ii(0x100a_9dbf, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_9dc3, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_9dc9, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_9dcf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_9dd4, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_9dd7, 2); if(jnzd(0x100a_9df2, 0x19)) goto l_0x100a_9df2; /* jnz 0x100a9df2 */
            ii(0x100a_9dd9, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_9ddd, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_9de3, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x100a_9de8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_9dea, 5); calld(0x100b_a0cd, 0x1_02de);           /* call 0x100ba0cd */
            ii(0x100a_9def, 3); add(memd_a32[ss, ebp - 0x8], eax);      /* add [ebp-0x8], eax */
        l_0x100a_9df2:
            ii(0x100a_9df2, 2); jmpd(0x100a_9db0, -0x44); goto l_0x100a_9db0; /* jmp 0x100a9db0 */
        l_0x100a_9df4:
            ii(0x100a_9df4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_9df7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_9dfa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_9dfd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9dff, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_9e00, 1); popd(edi);                              /* pop edi */
            ii(0x100a_9e01, 1); popd(esi);                              /* pop esi */
            ii(0x100a_9e02, 1); popd(edx);                              /* pop edx */
            ii(0x100a_9e03, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_9e04, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_9e05, 1); retd(); return;                         /* ret */
        }
    }
}
