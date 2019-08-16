using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a77effaf-edcc-4165-8ab0-b0742231310b")]
        public void Method_1008_d3e9()
        {
            ii(0x1008_d3e9, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1008_d3ee, 5); calld(Definitions.sys_check_available_stack_size, 0xd_895f); /* call 0x10165d52 */
            ii(0x1008_d3f3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_d3f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_d3f5, 1); pushd(edx);                             /* push edx */
            ii(0x1008_d3f6, 1); pushd(esi);                             /* push esi */
            ii(0x1008_d3f7, 1); pushd(edi);                             /* push edi */
            ii(0x1008_d3f8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_d3f9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_d3fb, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_d401, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_d404, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d407, 3); mov(eax, memd_a32[ds, eax + 0x22]);     /* mov eax, [eax+0x22] */
            ii(0x1008_d40a, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1008_d40d, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1008_d410, 2); if(jged(0x1008_d443, 0x31)) goto l_0x1008_d443; /* jge 0x1008d443 */
            ii(0x1008_d412, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d414, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d417, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d41a, 5); calld(0x1013_ad11, 0xa_d8f2);           /* call 0x1013ad11 */
            ii(0x1008_d41f, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d421, 2); if(jnzd(0x1008_d441, 0x1e)) goto l_0x1008_d441; /* jnz 0x1008d441 */
            ii(0x1008_d423, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d426, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d429, 5); calld(0x1008_af28, -0x2506);            /* call 0x1008af28 */
            ii(0x1008_d42e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_d431, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_d434, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_d437, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_d43a, 3); calld_abs(memd_a32[ds, edx + 0x24]);    /* call dword [edx+0x24] */
            ii(0x1008_d43d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d43f, 2); if(jzd(0x1008_d443, 0x2)) goto l_0x1008_d443; /* jz 0x1008d443 */
        l_0x1008_d441:
            ii(0x1008_d441, 2); jmpd(0x1008_d445, 0x2); goto l_0x1008_d445; /* jmp 0x1008d445 */
        l_0x1008_d443:
            ii(0x1008_d443, 2); jmpd(0x1008_d44b, 0x6); goto l_0x1008_d44b; /* jmp 0x1008d44b */
        l_0x1008_d445:
            ii(0x1008_d445, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_d449, 2); jmpd(0x1008_d44f, 0x4); goto l_0x1008_d44f; /* jmp 0x1008d44f */
        l_0x1008_d44b:
            ii(0x1008_d44b, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1008_d44f:
            ii(0x1008_d44f, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_d452, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1008_d455, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_d458, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_d45a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_d45b, 1); popd(edi);                              /* pop edi */
            ii(0x1008_d45c, 1); popd(esi);                              /* pop esi */
            ii(0x1008_d45d, 1); popd(edx);                              /* pop edx */
            ii(0x1008_d45e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_d45f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_d460, 1); retd(); return;                         /* ret */
        }
    }
}