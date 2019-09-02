using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_dd89-f202a0b2")]
        public void Method_1011_dd89()
        {
            ii(0x1011_dd89, 5); push(0x30);                             /* push 0x30 */
            ii(0x1011_dd8e, 5); call(Definitions.sys_check_available_stack_size, 0x4_7fbf); /* call 0x10165d52 */
            ii(0x1011_dd93, 1); push(ebx);                              /* push ebx */
            ii(0x1011_dd94, 1); push(ecx);                              /* push ecx */
            ii(0x1011_dd95, 1); push(edx);                              /* push edx */
            ii(0x1011_dd96, 1); push(esi);                              /* push esi */
            ii(0x1011_dd97, 1); push(edi);                              /* push edi */
            ii(0x1011_dd98, 1); push(ebp);                              /* push ebp */
            ii(0x1011_dd99, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_dd9b, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_dda1, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_dda4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_dda7, 4); cmp(memd[ds, eax + 22], 0);             /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_ddab, 2); if(jz(0x1011_dde1, 0x34)) goto l_0x1011_dde1; /* jz 0x1011dde1 */
            ii(0x1011_ddad, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_ddb0, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x1011_ddb3, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1011_ddb6, 4); cmp(memd[ss, ebp - 12], 0);             /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_ddba, 2); if(jz(0x1011_ddd0, 0x14)) goto l_0x1011_ddd0; /* jz 0x1011ddd0 */
            ii(0x1011_ddbc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_ddbe, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_ddc1, 5); call(Definitions.my_dtor_d7, -0x1b84);  /* call 0x1011c242 */
            ii(0x1011_ddc6, 5); call(Definitions.sys_delete, 0x4_8199); /* call 0x10165f64 */
            ii(0x1011_ddcb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_ddce, 2); jmp(0x1011_ddd7, 7); goto l_0x1011_ddd7; /* jmp 0x1011ddd7 */
        l_0x1011_ddd0:
            ii(0x1011_ddd0, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
        l_0x1011_ddd7:
            ii(0x1011_ddd7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_ddda, 7); mov(memd[ds, eax + 22], 0);             /* mov dword [eax+0x16], 0x0 */
        l_0x1011_dde1:
            ii(0x1011_dde1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_dde4, 4); cmp(memd[ds, eax + 26], 0);             /* cmp dword [eax+0x1a], 0x0 */
            ii(0x1011_dde8, 2); if(jz(0x1011_de1e, 0x34)) goto l_0x1011_de1e; /* jz 0x1011de1e */
            ii(0x1011_ddea, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_dded, 3); mov(eax, memd[ds, eax + 26]);           /* mov eax, [eax+0x1a] */
            ii(0x1011_ddf0, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1011_ddf3, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_ddf7, 2); if(jz(0x1011_de0d, 0x14)) goto l_0x1011_de0d; /* jz 0x1011de0d */
            ii(0x1011_ddf9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_ddfb, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1011_ddfe, 5); call(Definitions.my_dtor_d7, -0x1bc1);  /* call 0x1011c242 */
            ii(0x1011_de03, 5); call(Definitions.sys_delete, 0x4_815c); /* call 0x10165f64 */
            ii(0x1011_de08, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1011_de0b, 2); jmp(0x1011_de14, 7); goto l_0x1011_de14; /* jmp 0x1011de14 */
        l_0x1011_de0d:
            ii(0x1011_de0d, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
        l_0x1011_de14:
            ii(0x1011_de14, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_de17, 7); mov(memd[ds, eax + 26], 0);             /* mov dword [eax+0x1a], 0x0 */
        l_0x1011_de1e:
            ii(0x1011_de1e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_de20, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_de23, 5); call(0x100b_7fa4, -0x6_5e84);           /* call 0x100b7fa4 */
            ii(0x1011_de28, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_de2b, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1011_de2e, 5); call(0x1013_a6f4, 0x1_c8c1);            /* call 0x1013a6f4 */
            ii(0x1011_de33, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_de35, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_de36, 1); pop(edi);                               /* pop edi */
            ii(0x1011_de37, 1); pop(esi);                               /* pop esi */
            ii(0x1011_de38, 1); pop(edx);                               /* pop edx */
            ii(0x1011_de39, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_de3a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_de3b, 1); ret();                                  /* ret */
        }
    }
}
