using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_1035-ce63be68")]
        public void Method_1011_1035()
        {
            ii(0x1011_1035, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1011_103a, 5);  call(Definitions.sys_check_available_stack_size, 0x5_4d13);/* call 0x10165d52 */
            ii(0x1011_103f, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_1040, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_1041, 1);  push(edx);                            /* push edx */
            ii(0x1011_1042, 1);  push(esi);                            /* push esi */
            ii(0x1011_1043, 1);  push(edi);                            /* push edi */
            ii(0x1011_1044, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_1045, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_1047, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1011_104d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_1050, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_1053, 4);  cmp(memd[ds, eax + 12], 0xc);         /* cmp dword [eax+0xc], 0xc */
            ii(0x1011_1057, 2);  if(jnz(0x1011_1075, 0x1c)) goto l_0x1011_1075;/* jnz 0x10111075 */
            ii(0x1011_1059, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_105d, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1011_1060, 2);  if(jz(0x1011_10b4, 0x52)) goto l_0x1011_10b4;/* jz 0x101110b4 */
            ii(0x1011_1062, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_1065, 6);  mov(al, memb[ds, eax + 320]);         /* mov al, [eax+0x140] */
            ii(0x1011_106b, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_106d, 3);  sub(eax, 0xc);                        /* sub eax, 0xc */
            ii(0x1011_1070, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_1073, 2);  jmp(0x1011_1088, 0x13); goto l_0x1011_1088;/* jmp 0x10111088 */
        l_0x1011_1075:
            ii(0x1011_1075, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_1078, 6);  mov(al, memb[ds, eax + 320]);         /* mov al, [eax+0x140] */
            ii(0x1011_107e, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_1080, 5);  add(eax, 0xc);                        /* add eax, 0xc */
            ii(0x1011_1085, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1011_1088:
            ii(0x1011_1088, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1011_108c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_108f, 5);  call(0x1011_0e5a, -0x23a);            /* call 0x10110e5a */
            ii(0x1011_1094, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_1096, 2);  if(jz(0x1011_10b4, 0x1c)) goto l_0x1011_10b4;/* jz 0x101110b4 */
            ii(0x1011_1098, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1011_109b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_109e, 6);  mov(memb[ds, edx + 320], al);         /* mov [edx+0x140], al */
            ii(0x1011_10a4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_10a7, 5);  call(0x1011_0812, -0x89a);            /* call 0x10110812 */
            ii(0x1011_10ac, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_10af, 5);  call(0x1011_0496, -0xc1e);            /* call 0x10110496 */
        l_0x1011_10b4:
            ii(0x1011_10b4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_10b6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_10b7, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_10b8, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_10b9, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_10ba, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_10bb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_10bc, 1);  ret();                                /* ret */
        }
    }
}
