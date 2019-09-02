using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5bad-e93aaba0")]
        public void Method_1014_5bad()
        {
            ii(0x1014_5bad, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1014_5bb2, 5); call(Definitions.sys_check_available_stack_size, 0x2_019b); /* call 0x10165d52 */
            ii(0x1014_5bb7, 1); push(ebx);                              /* push ebx */
            ii(0x1014_5bb8, 1); push(ecx);                              /* push ecx */
            ii(0x1014_5bb9, 1); push(edx);                              /* push edx */
            ii(0x1014_5bba, 1); push(esi);                              /* push esi */
            ii(0x1014_5bbb, 1); push(edi);                              /* push edi */
            ii(0x1014_5bbc, 1); push(ebp);                              /* push ebp */
            ii(0x1014_5bbd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5bbf, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1014_5bc5, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_5bc8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_5bcb, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1014_5bce, 5); call(Definitions.my_strobj_c_str_v2, -0xb_c40b); /* call 0x100897c8 */
            ii(0x1014_5bd3, 5); call(Definitions.sys_strlen, 0x2_c2ef); /* call 0x10171ec7 */
            ii(0x1014_5bd8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_5bda, 2); if(jbe(0x1014_5c1e, 0x42)) goto l_0x1014_5c1e; /* jbe 0x10145c1e */
            ii(0x1014_5bdc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_5bdf, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x1014_5be2, 5); call(0x1014_7b64, 0x1f7d);              /* call 0x10147b64 */
            ii(0x1014_5be7, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1014_5be9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_5bec, 3); cmp(dl, memb[ds, eax + 0x27]);          /* cmp dl, [eax+0x27] */
            ii(0x1014_5bef, 2); if(jnz(0x1014_5bfe, 0xd)) goto l_0x1014_5bfe; /* jnz 0x10145bfe */
            ii(0x1014_5bf1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_5bf4, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x1014_5bf7, 5); call(0x1014_6722, 0xb26);               /* call 0x10146722 */
            ii(0x1014_5bfc, 2); jmp(0x1014_5c1e, 0x20); goto l_0x1014_5c1e; /* jmp 0x10145c1e */
        l_0x1014_5bfe:
            ii(0x1014_5bfe, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_5c01, 3); mov(al, memb[ds, eax + 0x27]);          /* mov al, [eax+0x27] */
            ii(0x1014_5c04, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_5c09, 1); push(eax);                              /* push eax */
            ii(0x1014_5c0a, 5); mov(eax, StringDefinitions.ExpectingAnC); /* mov eax, 0x101ad000 */
            ii(0x1014_5c0f, 1); push(eax);                              /* push eax */
            ii(0x1014_5c10, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_5c13, 3); push(memd[ds, eax + 0x14]);             /* push dword [eax+0x14] */
            ii(0x1014_5c16, 5); call(0x1014_6a6d, 0xe52);               /* call 0x10146a6d */
            ii(0x1014_5c1b, 3); add(esp, 0xc);                          /* add esp, 0xc */
        l_0x1014_5c1e:
            ii(0x1014_5c1e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_5c21, 4); mov(memb[ds, eax + 0x26], 1);           /* mov byte [eax+0x26], 0x1 */
            ii(0x1014_5c25, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5c27, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_5c28, 1); pop(edi);                               /* pop edi */
            ii(0x1014_5c29, 1); pop(esi);                               /* pop esi */
            ii(0x1014_5c2a, 1); pop(edx);                               /* pop edx */
            ii(0x1014_5c2b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_5c2c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_5c2d, 1); ret();                                  /* ret */
        }
    }
}
