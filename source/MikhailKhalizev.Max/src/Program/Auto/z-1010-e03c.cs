using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e03c-707770ea")]
        public void Method_1010_e03c()
        {
            ii(0x1010_e03c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_e041, 5); call(Definitions.sys_check_available_stack_size, 0x5_7d0c); /* call 0x10165d52 */
            ii(0x1010_e046, 1); push(ebx);                              /* push ebx */
            ii(0x1010_e047, 1); push(ecx);                              /* push ecx */
            ii(0x1010_e048, 1); push(edx);                              /* push edx */
            ii(0x1010_e049, 1); push(esi);                              /* push esi */
            ii(0x1010_e04a, 1); push(edi);                              /* push edi */
            ii(0x1010_e04b, 1); push(ebp);                              /* push ebp */
            ii(0x1010_e04c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_e04e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_e054, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_e057, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_e05a, 3); mov(al, memb[ds, eax + 0x10]);          /* mov al, [eax+0x10] */
            ii(0x1010_e05d, 2); add(al, 0x67);                          /* add al, 0x67 */
            ii(0x1010_e05f, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1010_e062, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_e065, 4); cmp(memd[ds, eax + 0xc], 0);            /* cmp dword [eax+0xc], 0x0 */
            ii(0x1010_e069, 2); if(jz(0x1010_e0d3, 0x68)) goto l_0x1010_e0d3; /* jz 0x1010e0d3 */
            ii(0x1010_e06b, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_e072, 2); jmp(0x1010_e07a, 6); goto l_0x1010_e07a; /* jmp 0x1010e07a */
        l_0x1010_e074:
            ii(0x1010_e074, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_e077, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x1010_e07a:
            ii(0x1010_e07a, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_e07e, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1010_e081, 2); if(jge(0x1010_e0d3, 0x50)) goto l_0x1010_e0d3; /* jge 0x1010e0d3 */
            ii(0x1010_e083, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1010_e086, 2); add(al, 0x67);                          /* add al, 0x67 */
            ii(0x1010_e088, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1010_e08b, 5); call(0x1007_5fdc, -0x9_80b4);           /* call 0x10075fdc */
            ii(0x1010_e090, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1010_e093, 2); if(jnz(0x1010_e0d1, 0x3c)) goto l_0x1010_e0d1; /* jnz 0x1010e0d1 */
            ii(0x1010_e095, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_e097, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_e09b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_e09e, 5); call(0x1010_dfd1, -0xd2);               /* call 0x1010dfd1 */
            ii(0x1010_e0a3, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_e0a7, 5); call(0x1007_5fdc, -0x9_80d0);           /* call 0x10075fdc */
            ii(0x1010_e0ac, 3); mov(dl, memb[ss, ebp - 0xc]);           /* mov dl, [ebp-0xc] */
            ii(0x1010_e0af, 3); add(dl, 0x67);                          /* add dl, 0x67 */
            ii(0x1010_e0b2, 3); movsx(ebx, dl);                         /* movsx ebx, dl */
            ii(0x1010_e0b5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_e0b7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_e0b9, 5); call(0x100c_aafc, -0x4_35c2);           /* call 0x100caafc */
            ii(0x1010_e0be, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1010_e0c3, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_e0c7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_e0ca, 5); call(0x1010_dfd1, -0xfe);               /* call 0x1010dfd1 */
            ii(0x1010_e0cf, 2); jmp(0x1010_e0d3, 2); goto l_0x1010_e0d3; /* jmp 0x1010e0d3 */
        l_0x1010_e0d1:
            ii(0x1010_e0d1, 2); jmp(0x1010_e074, -0x5f); goto l_0x1010_e074; /* jmp 0x1010e074 */
        l_0x1010_e0d3:
            ii(0x1010_e0d3, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1010_e0d8, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_e0dc, 5); call(0x100c_aafc, -0x4_35e5);           /* call 0x100caafc */
            ii(0x1010_e0e1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_e0e4, 5); call(0x1010_de32, -0x2b7);              /* call 0x1010de32 */
            ii(0x1010_e0e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_e0eb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_e0ec, 1); pop(edi);                               /* pop edi */
            ii(0x1010_e0ed, 1); pop(esi);                               /* pop esi */
            ii(0x1010_e0ee, 1); pop(edx);                               /* pop edx */
            ii(0x1010_e0ef, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_e0f0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_e0f1, 1); ret();                                  /* ret */
        }
    }
}
