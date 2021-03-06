using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_1370-a85487b")]
        public void Method_100f_1370()
        {
            ii(0x100f_1370, 5);  push(0x30);                           /* push 0x30 */
            ii(0x100f_1375, 5);  call(Definitions.sys_check_available_stack_size, 0x7_49d8);/* call 0x10165d52 */
            ii(0x100f_137a, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_137b, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_137c, 1);  push(edx);                            /* push edx */
            ii(0x100f_137d, 1);  push(esi);                            /* push esi */
            ii(0x100f_137e, 1);  push(edi);                            /* push edi */
            ii(0x100f_137f, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_1380, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_1382, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100f_1388, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_138b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_138e, 4);  cmp(memd[ds, eax + 16], 0);           /* cmp dword [eax+0x10], 0x0 */
            ii(0x100f_1392, 2);  if(jz(0x100f_13be, 0x2a)) goto l_0x100f_13be;/* jz 0x100f13be */
            ii(0x100f_1394, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1397, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100f_139a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100f_139d, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100f_13a1, 2);  if(jz(0x100f_13b7, 0x14)) goto l_0x100f_13b7;/* jz 0x100f13b7 */
            ii(0x100f_13a3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_13a5, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_13a8, 5);  call(Definitions.my_dtor_d2, -0x2_2e75);/* call 0x100ce538 */
            ii(0x100f_13ad, 5);  call(Definitions.sys_delete, 0x7_4bb2);/* call 0x10165f64 */
            ii(0x100f_13b2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_13b5, 2);  jmp(0x100f_13be, 7); goto l_0x100f_13be;/* jmp 0x100f13be */
        l_0x100f_13b7:
            ii(0x100f_13b7, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
        l_0x100f_13be:
            ii(0x100f_13be, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_13c1, 7);  mov(memd[ds, eax + 16], 0);           /* mov dword [eax+0x10], 0x0 */
            ii(0x100f_13c8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_13cb, 4);  cmp(memd[ds, eax + 20], 0);           /* cmp dword [eax+0x14], 0x0 */
            ii(0x100f_13cf, 2);  if(jz(0x100f_13fb, 0x2a)) goto l_0x100f_13fb;/* jz 0x100f13fb */
            ii(0x100f_13d1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_13d4, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100f_13d7, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_13da, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100f_13de, 2);  if(jz(0x100f_13f4, 0x14)) goto l_0x100f_13f4;/* jz 0x100f13f4 */
            ii(0x100f_13e0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_13e2, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_13e5, 5);  call(Definitions.my_dtor_d2, -0x2_2eb2);/* call 0x100ce538 */
            ii(0x100f_13ea, 5);  call(Definitions.sys_delete, 0x7_4b75);/* call 0x10165f64 */
            ii(0x100f_13ef, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_13f2, 2);  jmp(0x100f_13fb, 7); goto l_0x100f_13fb;/* jmp 0x100f13fb */
        l_0x100f_13f4:
            ii(0x100f_13f4, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x100f_13fb:
            ii(0x100f_13fb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_13fe, 7);  mov(memd[ds, eax + 20], 0);           /* mov dword [eax+0x14], 0x0 */
            ii(0x100f_1405, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_1407, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_1408, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_1409, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_140a, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_140b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_140c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_140d, 1);  ret();                                /* ret */
        }
    }
}
