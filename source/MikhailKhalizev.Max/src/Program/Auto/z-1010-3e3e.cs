using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_3e3e-863d2282")]
        public void Method_1010_3e3e()
        {
            ii(0x1010_3e3e, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_3e43, 5); call(Definitions.sys_check_available_stack_size, 0x6_1f0a); /* call 0x10165d52 */
            ii(0x1010_3e48, 1); push(ebx);                              /* push ebx */
            ii(0x1010_3e49, 1); push(ecx);                              /* push ecx */
            ii(0x1010_3e4a, 1); push(esi);                              /* push esi */
            ii(0x1010_3e4b, 1); push(edi);                              /* push edi */
            ii(0x1010_3e4c, 1); push(ebp);                              /* push ebp */
            ii(0x1010_3e4d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3e4f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_3e55, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_3e58, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_3e5b, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1010_3e5f, 2); if(jnz(0x1010_3e7a, 0x19)) goto l_0x1010_3e7a; /* jnz 0x10103e7a */
            ii(0x1010_3e61, 5); mov(ecx, 0x193);                        /* mov ecx, 0x193 */
            ii(0x1010_3e66, 5); mov(ebx, StringDefinitions.HashCpp3);   /* mov ebx, 0x101a322b */
            ii(0x1010_3e6b, 5); mov(edx, StringDefinitions.AttemptedToAddNullUnitFromUnitHashTable); /* mov edx, 0x101a3234 */
            ii(0x1010_3e70, 5); mov(eax, StringDefinitions.UnitNotEqual03); /* mov eax, 0x101a3265 */
            ii(0x1010_3e75, 5); call(0x100f_07d4, -0x1_36a6);           /* call 0x100f07d4 */
        l_0x1010_3e7a:
            ii(0x1010_3e7a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_3e7d, 5); call(0x1007_6154, -0x8_dd2e);           /* call 0x10076154 */
            ii(0x1010_3e82, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3e84, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x1010_3e87, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_3e8a, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x1010_3e8d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_3e8f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_3e92, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_3e94, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1010_3e97, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_3e9a, 4); movsx(ebx, memw[ss, ebp - 12]);         /* movsx ebx, word [ebp-0xc] */
            ii(0x1010_3e9e, 3); imul(ebx, ebx, 0xa);                    /* imul ebx, ebx, 0xa */
            ii(0x1010_3ea1, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_3ea4, 3); mov(edx, memd[ds, edx + 2]);            /* mov edx, [edx+0x2] */
            ii(0x1010_3ea7, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1010_3ea9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3eab, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_3ead, 5); call(0x1008_ab1c, -0x7_9396);           /* call 0x1008ab1c */
            ii(0x1010_3eb2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3eb4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_3eb5, 1); pop(edi);                               /* pop edi */
            ii(0x1010_3eb6, 1); pop(esi);                               /* pop esi */
            ii(0x1010_3eb7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_3eb8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_3eb9, 1); ret();                                  /* ret */
        }
    }
}
