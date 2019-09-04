using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_e342-5dedb342")]
        public void Method_1011_e342()
        {
            ii(0x1011_e342, 5); push(0x38);                             /* push 0x38 */
            ii(0x1011_e347, 5); call(Definitions.sys_check_available_stack_size, 0x4_7a06); /* call 0x10165d52 */
            ii(0x1011_e34c, 1); push(ebx);                              /* push ebx */
            ii(0x1011_e34d, 1); push(ecx);                              /* push ecx */
            ii(0x1011_e34e, 1); push(esi);                              /* push esi */
            ii(0x1011_e34f, 1); push(edi);                              /* push edi */
            ii(0x1011_e350, 1); push(ebp);                              /* push ebp */
            ii(0x1011_e351, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_e353, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1011_e359, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_e35c, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_e35f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1011_e362, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1011_e365, 5); call(0x1012_0940, 0x25d6);              /* call 0x10120940 */
            ii(0x1011_e36a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_e36d, 4); cmp(memd[ds, eax + 22], 0);             /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_e371, 2); if(jz(0x1011_e39d, 0x2a)) goto l_0x1011_e39d; /* jz 0x1011e39d */
            ii(0x1011_e373, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_e376, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x1011_e379, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1011_e37c, 4); cmp(memd[ss, ebp - 24], 0);             /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1011_e380, 2); if(jz(0x1011_e396, 0x14)) goto l_0x1011_e396; /* jz 0x1011e396 */
            ii(0x1011_e382, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e384, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1011_e387, 5); call(Definitions.my_dtor_d7, -0x214a);  /* call 0x1011c242 */
            ii(0x1011_e38c, 5); call(Definitions.sys_delete, 0x4_7bd3); /* call 0x10165f64 */
            ii(0x1011_e391, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1011_e394, 2); jmp(0x1011_e39d, 7); goto l_0x1011_e39d; /* jmp 0x1011e39d */
        l_0x1011_e396:
            ii(0x1011_e396, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
        l_0x1011_e39d:
            ii(0x1011_e39d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_e3a0, 4); cmp(memd[ds, eax + 26], 0);             /* cmp dword [eax+0x1a], 0x0 */
            ii(0x1011_e3a4, 2); if(jz(0x1011_e3d0, 0x2a)) goto l_0x1011_e3d0; /* jz 0x1011e3d0 */
            ii(0x1011_e3a6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_e3a9, 3); mov(eax, memd[ds, eax + 26]);           /* mov eax, [eax+0x1a] */
            ii(0x1011_e3ac, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1011_e3af, 4); cmp(memd[ss, ebp - 32], 0);             /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1011_e3b3, 2); if(jz(0x1011_e3c9, 0x14)) goto l_0x1011_e3c9; /* jz 0x1011e3c9 */
            ii(0x1011_e3b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e3b7, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1011_e3ba, 5); call(Definitions.my_dtor_d7, -0x217d);  /* call 0x1011c242 */
            ii(0x1011_e3bf, 5); call(Definitions.sys_delete, 0x4_7ba0); /* call 0x10165f64 */
            ii(0x1011_e3c4, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1011_e3c7, 2); jmp(0x1011_e3d0, 7); goto l_0x1011_e3d0; /* jmp 0x1011e3d0 */
        l_0x1011_e3c9:
            ii(0x1011_e3c9, 7); mov(memd[ss, ebp - 28], 0);             /* mov dword [ebp-0x1c], 0x0 */
        l_0x1011_e3d0:
            ii(0x1011_e3d0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_e3d3, 7); mov(memd[ds, eax + 22], 0);             /* mov dword [eax+0x16], 0x0 */
            ii(0x1011_e3da, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_e3dd, 7); mov(memd[ds, eax + 26], 0);             /* mov dword [eax+0x1a], 0x0 */
            ii(0x1011_e3e4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e3e6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_e3e9, 5); call(0x100b_7fa4, -0x6_644a);           /* call 0x100b7fa4 */
            ii(0x1011_e3ee, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1011_e3f1, 5); call(0x100b_7f18, -0x6_64de);           /* call 0x100b7f18 */
            ii(0x1011_e3f6, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1011_e3f9, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_e3fc, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1011_e3ff, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_e402, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_e405, 3); call_abs(memd[ds, ebx + 12]);           /* call dword [ebx+0xc] */
            ii(0x1011_e408, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e40a, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1011_e40d, 5); call(0x100b_7368, -0x6_70aa);           /* call 0x100b7368 */
            ii(0x1011_e412, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_e414, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_e415, 1); pop(edi);                               /* pop edi */
            ii(0x1011_e416, 1); pop(esi);                               /* pop esi */
            ii(0x1011_e417, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_e418, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_e419, 1); ret();                                  /* ret */
        }
    }
}
