using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4171-60dac55f")]
        public void Method_1010_4171()
        {
            ii(0x1010_4171, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_4176, 5); call(Definitions.sys_check_available_stack_size, 0x6_1bd7); /* call 0x10165d52 */
            ii(0x1010_417b, 1); push(ebx);                              /* push ebx */
            ii(0x1010_417c, 1); push(ecx);                              /* push ecx */
            ii(0x1010_417d, 1); push(esi);                              /* push esi */
            ii(0x1010_417e, 1); push(edi);                              /* push edi */
            ii(0x1010_417f, 1); push(ebp);                              /* push ebp */
            ii(0x1010_4180, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4182, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_4188, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_418b, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_418e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_4191, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1010_4194, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_4197, 5); call(0x1013_c0fa, 0x3_7f5e);            /* call 0x1013c0fa */
            ii(0x1010_419c, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_41a3, 2); jmp(0x1010_41ab, 6); goto l_0x1010_41ab; /* jmp 0x101041ab */
        l_0x1010_41a5:
            ii(0x1010_41a5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_41a8, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x1010_41ab:
            ii(0x1010_41ab, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_41ae, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_41b1, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x1010_41b4, 2); if(jge(0x1010_41cf, 0x19)) goto l_0x1010_41cf; /* jge 0x101041cf */
            ii(0x1010_41b6, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1010_41b9, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_41bd, 3); imul(ebx, eax, 0xa);                    /* imul ebx, eax, 0xa */
            ii(0x1010_41c0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_41c3, 3); mov(eax, memd[ds, eax + 2]);            /* mov eax, [eax+0x2] */
            ii(0x1010_41c6, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_41c8, 5); call(0x1010_2d8f, -0x143e);             /* call 0x10102d8f */
            ii(0x1010_41cd, 2); jmp(0x1010_41a5, -0x2a); goto l_0x1010_41a5; /* jmp 0x101041a5 */
        l_0x1010_41cf:
            ii(0x1010_41cf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_41d1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_41d2, 1); pop(edi);                               /* pop edi */
            ii(0x1010_41d3, 1); pop(esi);                               /* pop esi */
            ii(0x1010_41d4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_41d5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_41d6, 1); ret();                                  /* ret */
        }
    }
}
