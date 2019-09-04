using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_adca-656d1df1")]
        public void Method_1014_adca()
        {
            ii(0x1014_adca, 5); push(0x20);                             /* push 0x20 */
            ii(0x1014_adcf, 5); call(Definitions.sys_check_available_stack_size, 0x1_af7e); /* call 0x10165d52 */
            ii(0x1014_add4, 1); push(ebx);                              /* push ebx */
            ii(0x1014_add5, 1); push(ecx);                              /* push ecx */
            ii(0x1014_add6, 1); push(edx);                              /* push edx */
            ii(0x1014_add7, 1); push(esi);                              /* push esi */
            ii(0x1014_add8, 1); push(edi);                              /* push edi */
            ii(0x1014_add9, 1); push(ebp);                              /* push ebp */
            ii(0x1014_adda, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_addc, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1014_ade2, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_ade5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ade7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_adea, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_aded, 5); call(0x1007_6a34, -0xd_43be);           /* call 0x10076a34 */
            ii(0x1014_adf2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_adf4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_adf7, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_adfc, 5); call(0x1013_ad11, -0x1_00f0);           /* call 0x1013ad11 */
            ii(0x1014_ae01, 2); test(al, al);                           /* test al, al */
            ii(0x1014_ae03, 2); if(jz(0x1014_ae15, 0x10)) goto l_0x1014_ae15; /* jz 0x1014ae15 */
            ii(0x1014_ae05, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_ae08, 4); mov(memb[ds, eax + 61], 0);             /* mov byte [eax+0x3d], 0x0 */
            ii(0x1014_ae0c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_ae0f, 4); mov(memb[ds, eax + 62], 1);             /* mov byte [eax+0x3e], 0x1 */
            ii(0x1014_ae13, 2); jmp(0x1014_ae23, 0xe); goto l_0x1014_ae23; /* jmp 0x1014ae23 */
        l_0x1014_ae15:
            ii(0x1014_ae15, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_ae18, 4); mov(memb[ds, eax + 61], 4);             /* mov byte [eax+0x3d], 0x4 */
            ii(0x1014_ae1c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_ae1f, 4); mov(memb[ds, eax + 62], 0x1f);          /* mov byte [eax+0x3e], 0x1f */
        l_0x1014_ae23:
            ii(0x1014_ae23, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_ae26, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_ae29, 5); call(0x1009_caf8, -0xa_e336);           /* call 0x1009caf8 */
            ii(0x1014_ae2e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_ae30, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_ae31, 1); pop(edi);                               /* pop edi */
            ii(0x1014_ae32, 1); pop(esi);                               /* pop esi */
            ii(0x1014_ae33, 1); pop(edx);                               /* pop edx */
            ii(0x1014_ae34, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_ae35, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_ae36, 1); ret();                                  /* ret */
        }
    }
}
