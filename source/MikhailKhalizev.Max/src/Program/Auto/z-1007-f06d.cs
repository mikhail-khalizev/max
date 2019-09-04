using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_f06d-14f038f6")]
        public void Method_1007_f06d()
        {
            ii(0x1007_f06d, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_f072, 5); call(Definitions.sys_check_available_stack_size, 0xe_6cdb); /* call 0x10165d52 */
            ii(0x1007_f077, 1); push(ebx);                              /* push ebx */
            ii(0x1007_f078, 1); push(ecx);                              /* push ecx */
            ii(0x1007_f079, 1); push(edx);                              /* push edx */
            ii(0x1007_f07a, 1); push(esi);                              /* push esi */
            ii(0x1007_f07b, 1); push(edi);                              /* push edi */
            ii(0x1007_f07c, 1); push(ebp);                              /* push ebp */
            ii(0x1007_f07d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f07f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_f085, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_f088, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f08b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_f08e, 5); call(0x1007_6574, -0x8b1f);             /* call 0x10076574 */
            ii(0x1007_f093, 5); call(0x1015_2700, 0xd_3668);            /* call 0x10152700 */
            ii(0x1007_f098, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_f09a, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_f09d, 5); call(0x1008_ae70, 0xbdce);              /* call 0x1008ae70 */
        l_0x1007_f0a2:
            ii(0x1007_f0a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f0a4, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_f0a7, 5); call(0x1013_ad71, 0xb_bcc5);            /* call 0x1013ad71 */
            ii(0x1007_f0ac, 2); test(al, al);                           /* test al, al */
            ii(0x1007_f0ae, 2); if(jz(0x1007_f0cb, 0x1b)) goto l_0x1007_f0cb; /* jz 0x1007f0cb */
            ii(0x1007_f0b0, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_f0b3, 5); call(0x1008_adc4, 0xbd0c);              /* call 0x1008adc4 */
            ii(0x1007_f0b8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_f0bb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_f0be, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1007_f0c1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_f0c4, 3); call_abs(memd[ds, edx + 32]);           /* call dword [edx+0x20] */
            ii(0x1007_f0c7, 2); cmp(al, 0x30);                          /* cmp al, 0x30 */
            ii(0x1007_f0c9, 2); if(jnz(0x1007_f0cd, 2)) goto l_0x1007_f0cd; /* jnz 0x1007f0cd */
        l_0x1007_f0cb:
            ii(0x1007_f0cb, 2); jmp(0x1007_f0d7, 0xa); goto l_0x1007_f0d7; /* jmp 0x1007f0d7 */
        l_0x1007_f0cd:
            ii(0x1007_f0cd, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_f0d0, 5); call(0x1007_6bf8, -0x84dd);             /* call 0x10076bf8 */
            ii(0x1007_f0d5, 2); jmp(0x1007_f0a2, -0x35); goto l_0x1007_f0a2; /* jmp 0x1007f0a2 */
        l_0x1007_f0d7:
            ii(0x1007_f0d7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f0d9, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_f0dc, 5); call(0x1013_ad11, 0xb_bc30);            /* call 0x1013ad11 */
            ii(0x1007_f0e1, 2); test(al, al);                           /* test al, al */
            ii(0x1007_f0e3, 2); if(jz(0x1007_f0fa, 0x15)) goto l_0x1007_f0fa; /* jz 0x1007f0fa */
            ii(0x1007_f0e5, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_f0e8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f0eb, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_f0ee, 5); call(0x1007_6574, -0x8b7f);             /* call 0x10076574 */
            ii(0x1007_f0f3, 5); call(0x1015_27ed, 0xd_36f5);            /* call 0x101527ed */
            ii(0x1007_f0f8, 2); jmp(0x1007_f114, 0x1a); goto l_0x1007_f114; /* jmp 0x1007f114 */
        l_0x1007_f0fa:
            ii(0x1007_f0fa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f0fc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f0ff, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_f102, 5); call(0x1008_afe4, 0xbedd);              /* call 0x1008afe4 */
            ii(0x1007_f107, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_f10a, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_f10f, 5); call(0x100a_5e27, 0x2_6d13);            /* call 0x100a5e27 */
        l_0x1007_f114:
            ii(0x1007_f114, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_f116, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_f119, 5); call(0x1008_8bbc, 0x9a9e);              /* call 0x10088bbc */
            ii(0x1007_f11e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f120, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_f121, 1); pop(edi);                               /* pop edi */
            ii(0x1007_f122, 1); pop(esi);                               /* pop esi */
            ii(0x1007_f123, 1); pop(edx);                               /* pop edx */
            ii(0x1007_f124, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_f125, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_f126, 1); ret();                                  /* ret */
        }
    }
}
