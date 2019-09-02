using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_0b11-c88405a4")]
        public void Method_1007_0b11()
        {
            ii(0x1007_0b11, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_0b16, 5); call(Definitions.sys_check_available_stack_size, 0xf_5237); /* call 0x10165d52 */
            ii(0x1007_0b1b, 1); push(ebx);                              /* push ebx */
            ii(0x1007_0b1c, 1); push(ecx);                              /* push ecx */
            ii(0x1007_0b1d, 1); push(edx);                              /* push edx */
            ii(0x1007_0b1e, 1); push(esi);                              /* push esi */
            ii(0x1007_0b1f, 1); push(edi);                              /* push edi */
            ii(0x1007_0b20, 1); push(ebp);                              /* push ebp */
            ii(0x1007_0b21, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_0b23, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_0b29, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_0b2c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_0b2f, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_0b33, 2); if(jz(0x1007_0b48, 0x13)) goto l_0x1007_0b48; /* jz 0x10070b48 */
            ii(0x1007_0b35, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_0b38, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_0b3a, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_0b3d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_0b3f, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1007_0b44, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_0b46, 2); if(jz(0x1007_0b51, 9)) goto l_0x1007_0b51; /* jz 0x10070b51 */
        l_0x1007_0b48:
            ii(0x1007_0b48, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_0b4f, 2); jmp(0x1007_0b71, 0x20); goto l_0x1007_0b71; /* jmp 0x10070b71 */
        l_0x1007_0b51:
            ii(0x1007_0b51, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_0b54, 5); cmp(memw[ds, eax + 8], 0x39);           /* cmp word [eax+0x8], 0x39 */
            ii(0x1007_0b59, 2); if(jnz(0x1007_0b64, 9)) goto l_0x1007_0b64; /* jnz 0x10070b64 */
            ii(0x1007_0b5b, 7); mov(memd[ss, ebp - 0xc], 1);            /* mov dword [ebp-0xc], 0x1 */
            ii(0x1007_0b62, 2); jmp(0x1007_0b6b, 7); goto l_0x1007_0b6b; /* jmp 0x10070b6b */
        l_0x1007_0b64:
            ii(0x1007_0b64, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
        l_0x1007_0b6b:
            ii(0x1007_0b6b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_0b6e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1007_0b71:
            ii(0x1007_0b71, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_0b74, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_0b76, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_0b77, 1); pop(edi);                               /* pop edi */
            ii(0x1007_0b78, 1); pop(esi);                               /* pop esi */
            ii(0x1007_0b79, 1); pop(edx);                               /* pop edx */
            ii(0x1007_0b7a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_0b7b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_0b7c, 1); ret();                                  /* ret */
        }
    }
}
