using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_01a2-e47278df")]
        public void Method_100b_01a2()
        {
            ii(0x100b_01a2, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_01a7, 5); call(Definitions.sys_check_available_stack_size, 0xb_5ba6); /* call 0x10165d52 */
            ii(0x100b_01ac, 1); push(ebx);                              /* push ebx */
            ii(0x100b_01ad, 1); push(ecx);                              /* push ecx */
            ii(0x100b_01ae, 1); push(esi);                              /* push esi */
            ii(0x100b_01af, 1); push(edi);                              /* push edi */
            ii(0x100b_01b0, 1); push(ebp);                              /* push ebp */
            ii(0x100b_01b1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_01b3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_01b9, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_01bc, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_01bf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_01c1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_01c4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_01c7, 5); call(0x1013_ad11, 0x8_ab45);            /* call 0x1013ad11 */
            ii(0x100b_01cc, 2); test(al, al);                           /* test al, al */
            ii(0x100b_01ce, 2); if(jz(0x100b_01df, 0xf)) goto l_0x100b_01df; /* jz 0x100b01df */
            ii(0x100b_01d0, 5); mov(edx, StringDefinitions.DumpUnitTaskNullMove); /* mov edx, 0x101a0f0d */
            ii(0x100b_01d5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_01d8, 5); call(Definitions.sys_strcpy, 0xb_5cf2); /* call 0x10165ecf */
            ii(0x100b_01dd, 2); jmp(0x100b_0236, 0x57); goto l_0x100b_0236; /* jmp 0x100b0236 */
        l_0x100b_01df:
            ii(0x100b_01df, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_01e2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_01e5, 5); call(0x1008_a520, -0x2_5cca);           /* call 0x1008a520 */
            ii(0x100b_01ea, 5); call(0x100b_7d68, 0x7b79);              /* call 0x100b7d68 */
            ii(0x100b_01ef, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_01f1, 2); if(jnz(0x100b_0202, 0xf)) goto l_0x100b_0202; /* jnz 0x100b0202 */
            ii(0x100b_01f3, 5); mov(edx, StringDefinitions.DumpUnitTaskNullUnit); /* mov edx, 0x101a0f28 */
            ii(0x100b_01f8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_01fb, 5); call(Definitions.sys_strcpy, 0xb_5ccf); /* call 0x10165ecf */
            ii(0x100b_0200, 2); jmp(0x100b_0236, 0x34); goto l_0x100b_0236; /* jmp 0x100b0236 */
        l_0x100b_0202:
            ii(0x100b_0202, 5); mov(edx, StringDefinitions.FindAPlaceToUnload); /* mov edx, 0x101a0f43 */
            ii(0x100b_0207, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_020a, 5); call(Definitions.sys_strcpy, 0xb_5cc0); /* call 0x10165ecf */
            ii(0x100b_020f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_0212, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_0215, 5); call(0x1008_a520, -0x2_5cfa);           /* call 0x1008a520 */
            ii(0x100b_021a, 5); call(0x100b_7d68, 0x7b49);              /* call 0x100b7d68 */
            ii(0x100b_021f, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100b_0222, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_0225, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100b_0228, 6); mov(edx, memd[ds, eax + 0x101c_81d7]);  /* mov edx, [eax+0x101c81d7] */
            ii(0x100b_022e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_0231, 5); call(Definitions.sys_strcat, 0xb_5cfb); /* call 0x10165f31 */
        l_0x100b_0236:
            ii(0x100b_0236, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_0239, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_023c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_023f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0241, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_0242, 1); pop(edi);                               /* pop edi */
            ii(0x100b_0243, 1); pop(esi);                               /* pop esi */
            ii(0x100b_0244, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_0245, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_0246, 1); ret();                                  /* ret */
        }
    }
}
