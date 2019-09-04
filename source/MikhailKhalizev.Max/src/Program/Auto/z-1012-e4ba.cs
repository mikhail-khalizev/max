using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_e4ba-6c3ce116")]
        public void Method_1012_e4ba()
        {
            ii(0x1012_e4ba, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_e4bf, 5); call(Definitions.sys_check_available_stack_size, 0x3_788e); /* call 0x10165d52 */
            ii(0x1012_e4c4, 1); push(ebx);                              /* push ebx */
            ii(0x1012_e4c5, 1); push(ecx);                              /* push ecx */
            ii(0x1012_e4c6, 1); push(edx);                              /* push edx */
            ii(0x1012_e4c7, 1); push(esi);                              /* push esi */
            ii(0x1012_e4c8, 1); push(edi);                              /* push edi */
            ii(0x1012_e4c9, 1); push(ebp);                              /* push ebp */
            ii(0x1012_e4ca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_e4cc, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1012_e4d2, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_e4d5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_e4d8, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e4db, 5); call(Definitions.my_1_get_count, -0x8_3008); /* call 0x100ab4d8 */
            ii(0x1012_e4e0, 1); cwde();                                 /* cwde */
            ii(0x1012_e4e1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_e4e3, 2); if(jz(0x1012_e54b, 0x66)) goto l_0x1012_e54b; /* jz 0x1012e54b */
            ii(0x1012_e4e5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_e4e7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_e4ea, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1012_e4ed, 5); call(0x1013_ad11, 0xc81f);              /* call 0x1013ad11 */
            ii(0x1012_e4f2, 2); test(al, al);                           /* test al, al */
            ii(0x1012_e4f4, 2); if(jz(0x1012_e507, 0x11)) goto l_0x1012_e507; /* jz 0x1012e507 */
            ii(0x1012_e4f6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_e4f9, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e4fc, 5); call(Definitions.my_1_get_count, -0x8_3029); /* call 0x100ab4d8 */
            ii(0x1012_e501, 1); inc(eax);                               /* inc eax */
            ii(0x1012_e502, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_e505, 2); jmp(0x1012_e51f, 0x18); goto l_0x1012_e51f; /* jmp 0x1012e51f */
        l_0x1012_e507:
            ii(0x1012_e507, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_e50a, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1012_e50d, 5); call(0x1013_1c0c, 0x36fa);              /* call 0x10131c0c */
            ii(0x1012_e512, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_e514, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_e517, 5); call(0x1012_e2a7, -0x275);              /* call 0x1012e2a7 */
            ii(0x1012_e51c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1012_e51f:
            ii(0x1012_e51f, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1012_e523, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1012_e526, 2); if(jl(0x1012_e54b, 0x23)) goto l_0x1012_e54b; /* jl 0x1012e54b */
            ii(0x1012_e528, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_e52b, 3); sub(eax, 2);                            /* sub eax, 0x2 */
            ii(0x1012_e52e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_e531, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_e534, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e537, 5); call(0x1013_18f8, 0x33bc);              /* call 0x101318f8 */
            ii(0x1012_e53c, 5); call(0x1013_19f4, 0x34b3);              /* call 0x101319f4 */
            ii(0x1012_e541, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_e543, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_e546, 5); call(0x1012_e37c, -0x1cf);              /* call 0x1012e37c */
        l_0x1012_e54b:
            ii(0x1012_e54b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_e54d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_e54e, 1); pop(edi);                               /* pop edi */
            ii(0x1012_e54f, 1); pop(esi);                               /* pop esi */
            ii(0x1012_e550, 1); pop(edx);                               /* pop edx */
            ii(0x1012_e551, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_e552, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_e553, 1); ret();                                  /* ret */
        }
    }
}
