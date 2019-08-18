using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8132-fb0b0bc0")]
        public void Method_1010_8132()
        {
            ii(0x1010_8132, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_8137, 5); calld(Definitions.sys_check_available_stack_size, 0x5_dc16); /* call 0x10165d52 */
            ii(0x1010_813c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_813d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_813e, 1); pushd(esi);                             /* push esi */
            ii(0x1010_813f, 1); pushd(edi);                             /* push edi */
            ii(0x1010_8140, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_8141, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8143, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_8149, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_814c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_814f, 3); lea(edi, ebp - 0x10);                   /* lea edi, [ebp-0x10] */
            ii(0x1010_8152, 5); mov(esi, 0x101b_9010);                  /* mov esi, 0x101b9010 */
            ii(0x1010_8157, 1); movsd_a32();                            /* movsd */
            ii(0x1010_8158, 2); movsw_a32();                            /* movsw */
            ii(0x1010_815a, 7); cmp(memd_a32[ds, 0x101c_4db8], 0);      /* cmp dword [0x101c4db8], 0x0 */
            ii(0x1010_8161, 2); if(jzd(0x1010_817a, 0x17)) goto l_0x1010_817a; /* jz 0x1010817a */
            ii(0x1010_8163, 5); mov(ecx, 0x101c_4dc0);                  /* mov ecx, 0x101c4dc0 */
            ii(0x1010_8168, 5); mov(ebx, 0x101c_4dbc);                  /* mov ebx, 0x101c4dbc */
            ii(0x1010_816d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_8170, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_8173, 5); calld(0x1010_8192, 0x1a);               /* call 0x10108192 */
            ii(0x1010_8178, 2); jmpd(0x1010_818a, 0x10); goto l_0x1010_818a; /* jmp 0x1010818a */
        l_0x1010_817a:
            ii(0x1010_817a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_817c, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x1010_817f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_8182, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_8185, 5); calld(0x1010_7e6a, -0x320);             /* call 0x10107e6a */
        l_0x1010_818a:
            ii(0x1010_818a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_818c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_818d, 1); popd(edi);                              /* pop edi */
            ii(0x1010_818e, 1); popd(esi);                              /* pop esi */
            ii(0x1010_818f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_8190, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_8191, 1); retd(); return;                         /* ret */
        }
    }
}
