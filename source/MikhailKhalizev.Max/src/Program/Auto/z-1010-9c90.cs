using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_9c90-bc50e429")]
        public void Method_1010_9c90()
        {
            ii(0x1010_9c90, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_9c95, 5); calld(Definitions.sys_check_available_stack_size, 0x5_c0b8); /* call 0x10165d52 */
            ii(0x1010_9c9a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_9c9b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_9c9c, 1); pushd(edx);                             /* push edx */
            ii(0x1010_9c9d, 1); pushd(esi);                             /* push esi */
            ii(0x1010_9c9e, 1); pushd(edi);                             /* push edi */
            ii(0x1010_9c9f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_9ca0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_9ca2, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_9ca8, 7); cmp(memd_a32[ds, 0x101c_4e48], 0);      /* cmp dword [0x101c4e48], 0x0 */
            ii(0x1010_9caf, 2); if(jzd(0x1010_9ce5, 0x34)) goto l_0x1010_9ce5; /* jz 0x10109ce5 */
            ii(0x1010_9cb1, 6); mov(ax, memw_a32[ds, 0x101c_4e4c]);     /* mov ax, [0x101c4e4c] */
            ii(0x1010_9cb7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1010_9cba:
            ii(0x1010_9cba, 3); dec(memd_a32[ss, ebp - 0x4]);           /* dec dword [ebp-0x4] */
            ii(0x1010_9cbd, 5); cmp(memw_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x1010_9cc2, 2); if(jzd(0x1010_9ce5, 0x21)) goto l_0x1010_9ce5; /* jz 0x10109ce5 */
            ii(0x1010_9cc4, 5); calld(0x100d_51c4, -0x3_4b05);          /* call 0x100d51c4 */
            ii(0x1010_9cc9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_9ccb, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1010_9ccd, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_9cd1, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9cd4, 6); mov(ebx, memd_a32[ds, 0x101c_4e48]);    /* mov ebx, [0x101c4e48] */
            ii(0x1010_9cda, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_9cdc, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_9cde, 5); calld(0x100c_fb06, -0x3_a1dd);          /* call 0x100cfb06 */
            ii(0x1010_9ce3, 2); jmpd(0x1010_9cba, -0x2b); goto l_0x1010_9cba; /* jmp 0x10109cba */
        l_0x1010_9ce5:
            ii(0x1010_9ce5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_9ce7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_9ce8, 1); popd(edi);                              /* pop edi */
            ii(0x1010_9ce9, 1); popd(esi);                              /* pop esi */
            ii(0x1010_9cea, 1); popd(edx);                              /* pop edx */
            ii(0x1010_9ceb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_9cec, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_9ced, 1); retd(); return;                         /* ret */
        }
    }
}
