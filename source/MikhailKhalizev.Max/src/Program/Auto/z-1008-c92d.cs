using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_c92d-e7801a28")]
        public void Method_1008_c92d()
        {
            ii(0x1008_c92d, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_c932, 5); call(Definitions.sys_check_available_stack_size, 0xd_941b); /* call 0x10165d52 */
            ii(0x1008_c937, 1); push(ebx);                              /* push ebx */
            ii(0x1008_c938, 1); push(ecx);                              /* push ecx */
            ii(0x1008_c939, 1); push(edx);                              /* push edx */
            ii(0x1008_c93a, 1); push(esi);                              /* push esi */
            ii(0x1008_c93b, 1); push(edi);                              /* push edi */
            ii(0x1008_c93c, 1); push(ebp);                              /* push ebp */
            ii(0x1008_c93d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_c93f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_c945, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_c948, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c94a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c94d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_c950, 5); call(0x1013_ad11, 0xa_e3bc);            /* call 0x1013ad11 */
            ii(0x1008_c955, 2); test(al, al);                           /* test al, al */
            ii(0x1008_c957, 2); if(jnz(0x1008_c96f, 0x16)) goto l_0x1008_c96f; /* jnz 0x1008c96f */
            ii(0x1008_c959, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c95c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_c95f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_c962, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1008_c965, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_c968, 3); call_abs(memd[ds, edx + 0x70]);         /* call dword [edx+0x70] */
            ii(0x1008_c96b, 2); test(al, al);                           /* test al, al */
            ii(0x1008_c96d, 2); if(jnz(0x1008_c978, 0x9)) goto l_0x1008_c978; /* jnz 0x1008c978 */
        l_0x1008_c96f:
            ii(0x1008_c96f, 7); mov(memd[ss, ebp - 0x8], 0x64);         /* mov dword [ebp-0x8], 0x64 */
            ii(0x1008_c976, 2); jmp(0x1008_c98d, 0x15); goto l_0x1008_c98d; /* jmp 0x1008c98d */
        l_0x1008_c978:
            ii(0x1008_c978, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c97b, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_c97e, 5); call(0x1007_6574, -0x1_640f);           /* call 0x10076574 */
            ii(0x1008_c983, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c985, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_c987, 3); mov(al, memb[ds, edx + 0x45]);          /* mov al, [edx+0x45] */
            ii(0x1008_c98a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x1008_c98d:
            ii(0x1008_c98d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_c990, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_c992, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_c993, 1); pop(edi);                               /* pop edi */
            ii(0x1008_c994, 1); pop(esi);                               /* pop esi */
            ii(0x1008_c995, 1); pop(edx);                               /* pop edx */
            ii(0x1008_c996, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_c997, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_c998, 1); ret();                                  /* ret */
        }
    }
}
