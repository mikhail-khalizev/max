using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_0a0a-2ccda5f4")]
        public void Method_100a_0a0a()
        {
            ii(0x100a_0a0a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_0a0f, 5); calld(Definitions.sys_check_available_stack_size, 0xc_533e); /* call 0x10165d52 */
            ii(0x100a_0a14, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_0a15, 1); pushd(esi);                             /* push esi */
            ii(0x100a_0a16, 1); pushd(edi);                             /* push edi */
            ii(0x100a_0a17, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_0a18, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_0a1a, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_0a20, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_0a23, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_0a26, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_0a29, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_0a2d, 6); if(jzd(0x100a_0a9e, 0x6b)) goto l_0x100a_0a9e; /* jz 0x100a0a9e */
            ii(0x100a_0a33, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_0a36, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_0a39, 2); jmpd(0x100a_0a7f, 0x44); goto l_0x100a_0a7f; /* jmp 0x100a0a7f */
        l_0x100a_0a3b:
            ii(0x100a_0a3b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0a3e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0a41, 4); add(memw_a32[ds, edx + 0x20], ax);      /* add [edx+0x20], ax */
            ii(0x100a_0a45, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0a48, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0a4b, 4); add(memw_a32[ds, edx + 0x2c], ax);      /* add [edx+0x2c], ax */
            ii(0x100a_0a4f, 2); jmpd(0x100a_0a9e, 0x4d); goto l_0x100a_0a9e; /* jmp 0x100a0a9e */
        l_0x100a_0a51:
            ii(0x100a_0a51, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0a54, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0a57, 4); add(memw_a32[ds, edx + 0x1e], ax);      /* add [edx+0x1e], ax */
            ii(0x100a_0a5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0a5e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0a61, 4); add(memw_a32[ds, edx + 0x2a], ax);      /* add [edx+0x2a], ax */
            ii(0x100a_0a65, 2); jmpd(0x100a_0a9e, 0x37); goto l_0x100a_0a9e; /* jmp 0x100a0a9e */
        l_0x100a_0a67:
            ii(0x100a_0a67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0a6a, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0a6d, 4); add(memw_a32[ds, edx + 0x22], ax);      /* add [edx+0x22], ax */
            ii(0x100a_0a71, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0a74, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_0a77, 4); add(memw_a32[ds, edx + 0x2e], ax);      /* add [edx+0x2e], ax */
            ii(0x100a_0a7b, 2); jmpd(0x100a_0a9e, 0x21); goto l_0x100a_0a9e; /* jmp 0x100a0a9e */
        l_0x100a_0a7d:
            ii(0x100a_0a7d, 2); jmpd(0x100a_0a9e, 0x1f); goto l_0x100a_0a9e; /* jmp 0x100a0a9e */
        l_0x100a_0a7f:
            ii(0x100a_0a7f, 4); cmp(memd_a32[ss, ebp - 0x10], 0x40);    /* cmp dword [ebp-0x10], 0x40 */
            ii(0x100a_0a83, 2); if(jbd(0x100a_0a96, 0x11)) goto l_0x100a_0a96; /* jb 0x100a0a96 */
            ii(0x100a_0a85, 4); cmp(memd_a32[ss, ebp - 0x10], 0x40);    /* cmp dword [ebp-0x10], 0x40 */
            ii(0x100a_0a89, 2); if(jbed(0x100a_0a51, -0x3a)) goto l_0x100a_0a51; /* jbe 0x100a0a51 */
            ii(0x100a_0a8b, 7); cmp(memd_a32[ss, ebp - 0x10], 0x80);    /* cmp dword [ebp-0x10], 0x80 */
            ii(0x100a_0a92, 2); if(jzd(0x100a_0a3b, -0x59)) goto l_0x100a_0a3b; /* jz 0x100a0a3b */
            ii(0x100a_0a94, 2); jmpd(0x100a_0a7d, -0x19); goto l_0x100a_0a7d; /* jmp 0x100a0a7d */
        l_0x100a_0a96:
            ii(0x100a_0a96, 4); cmp(memd_a32[ss, ebp - 0x10], 0x20);    /* cmp dword [ebp-0x10], 0x20 */
            ii(0x100a_0a9a, 2); if(jzd(0x100a_0a67, -0x35)) goto l_0x100a_0a67; /* jz 0x100a0a67 */
            ii(0x100a_0a9c, 2); jmpd(0x100a_0a7d, -0x21); goto l_0x100a_0a7d; /* jmp 0x100a0a7d */
        l_0x100a_0a9e:
            ii(0x100a_0a9e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_0aa0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_0aa1, 1); popd(edi);                              /* pop edi */
            ii(0x100a_0aa2, 1); popd(esi);                              /* pop esi */
            ii(0x100a_0aa3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_0aa4, 1); retd();                                 /* ret */
        }
    }
}
