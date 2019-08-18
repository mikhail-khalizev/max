using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("64e3dfbd-d6bd-40b6-abb0-5278788d39da")]
        public void Method_1010_9c29()
        {
            ii(0x1010_9c29, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_9c2e, 5); calld(Definitions.sys_check_available_stack_size, 0x5_c11f); /* call 0x10165d52 */
            ii(0x1010_9c33, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_9c34, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_9c35, 1); pushd(edx);                             /* push edx */
            ii(0x1010_9c36, 1); pushd(esi);                             /* push esi */
            ii(0x1010_9c37, 1); pushd(edi);                             /* push edi */
            ii(0x1010_9c38, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_9c39, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_9c3b, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_9c41, 7); cmp(memd_a32[ds, 0x101c_4e48], 0);      /* cmp dword [0x101c4e48], 0x0 */
            ii(0x1010_9c48, 2); if(jzd(0x1010_9c87, 0x3d)) goto l_0x1010_9c87; /* jz 0x10109c87 */
            ii(0x1010_9c4a, 6); mov(ax, memw_a32[ds, 0x101c_4e4c]);     /* mov ax, [0x101c4e4c] */
            ii(0x1010_9c50, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1010_9c53:
            ii(0x1010_9c53, 3); dec(memd_a32[ss, ebp - 0x4]);           /* dec dword [ebp-0x4] */
            ii(0x1010_9c56, 5); cmp(memw_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x1010_9c5b, 2); if(jzd(0x1010_9c87, 0x2a)) goto l_0x1010_9c87; /* jz 0x10109c87 */
            ii(0x1010_9c5d, 5); calld(0x100d_51e4, -0x3_4a7e);          /* call 0x100d51e4 */
            ii(0x1010_9c62, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_9c64, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_9c66, 5); calld(0x100d_5204, -0x3_4a67);          /* call 0x100d5204 */
            ii(0x1010_9c6b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_9c6d, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1010_9c6f, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_9c73, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1010_9c76, 6); mov(ecx, memd_a32[ds, 0x101c_4e48]);    /* mov ecx, [0x101c4e48] */
            ii(0x1010_9c7c, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1010_9c7e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_9c80, 5); calld(0x100c_fa7c, -0x3_a209);          /* call 0x100cfa7c */
            ii(0x1010_9c85, 2); jmpd(0x1010_9c53, -0x34); goto l_0x1010_9c53; /* jmp 0x10109c53 */
        l_0x1010_9c87:
            ii(0x1010_9c87, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_9c89, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_9c8a, 1); popd(edi);                              /* pop edi */
            ii(0x1010_9c8b, 1); popd(esi);                              /* pop esi */
            ii(0x1010_9c8c, 1); popd(edx);                              /* pop edx */
            ii(0x1010_9c8d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_9c8e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_9c8f, 1); retd(); return;                         /* ret */
        }
    }
}
