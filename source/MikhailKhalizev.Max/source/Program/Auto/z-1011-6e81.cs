using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_6e81-1f2ba7ba")]
        public void Method_1011_6e81()
        {
            ii(0x1011_6e81, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1011_6e86, 5);  call(Definitions.sys_check_available_stack_size, 0x4_eec7);/* call 0x10165d52 */
            ii(0x1011_6e8b, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_6e8c, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_6e8d, 1);  push(esi);                            /* push esi */
            ii(0x1011_6e8e, 1);  push(edi);                            /* push edi */
            ii(0x1011_6e8f, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_6e90, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_6e92, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1011_6e98, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_6e9b, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_6e9e, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1011_6ea5, 2);  if(jz(0x1011_6ebe, 0x17)) goto l_0x1011_6ebe;/* jz 0x10116ebe */
            ii(0x1011_6ea7, 5);  mov(edx, 0x101b_6708);                /* mov edx, 0x101b6708 */
            ii(0x1011_6eac, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6eaf, 5);  call(Definitions.sys_call_dtor_arr, 0x4_f104);/* call 0x10165fb8 */
            ii(0x1011_6eb4, 5);  call(Definitions.sys_delete_arr, 0x4_f11f);/* call 0x10165fd8 */
            ii(0x1011_6eb9, 5);  jmp(0x1011_6f42, 0x84); goto l_0x1011_6f42;/* jmp 0x10116f42 */
        l_0x1011_6ebe:
            ii(0x1011_6ebe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6ec1, 7);  mov(memd[ds, eax + 19], 0x101b_673c); /* mov dword [eax+0x13], 0x101b673c */
            ii(0x1011_6ec8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6ecb, 3);  mov(eax, memd[ds, eax + 51]);         /* mov eax, [eax+0x33] */
            ii(0x1011_6ece, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_6ed1, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1011_6ed5, 2);  if(jz(0x1011_6eeb, 0x14)) goto l_0x1011_6eeb;/* jz 0x10116eeb */
            ii(0x1011_6ed7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_6ed9, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_6edc, 5);  call(Definitions.my_dtor_d2, -0x4_89a9);/* call 0x100ce538 */
            ii(0x1011_6ee1, 5);  call(Definitions.sys_delete, 0x4_f07e);/* call 0x10165f64 */
            ii(0x1011_6ee6, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_6ee9, 2);  jmp(0x1011_6ef2, 7); goto l_0x1011_6ef2;/* jmp 0x10116ef2 */
        l_0x1011_6eeb:
            ii(0x1011_6eeb, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
        l_0x1011_6ef2:
            ii(0x1011_6ef2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6ef5, 3);  mov(eax, memd[ds, eax + 55]);         /* mov eax, [eax+0x37] */
            ii(0x1011_6ef8, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_6efb, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1011_6eff, 2);  if(jz(0x1011_6f15, 0x14)) goto l_0x1011_6f15;/* jz 0x10116f15 */
            ii(0x1011_6f01, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_6f03, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_6f06, 5);  call(Definitions.my_dtor_d2, -0x4_89d3);/* call 0x100ce538 */
            ii(0x1011_6f0b, 5);  call(Definitions.sys_delete, 0x4_f054);/* call 0x10165f64 */
            ii(0x1011_6f10, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_6f13, 2);  jmp(0x1011_6f1c, 7); goto l_0x1011_6f1c;/* jmp 0x10116f1c */
        l_0x1011_6f15:
            ii(0x1011_6f15, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1011_6f1c:
            ii(0x1011_6f1c, 5);  call(0x100e_a903, -0x2_c61e);         /* call 0x100ea903 */
            ii(0x1011_6f21, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1011_6f26, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6f29, 5);  call(0x100d_6999, -0x4_0595);         /* call 0x100d6999 */
            ii(0x1011_6f2e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_6f31, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1011_6f38, 2);  if(jz(0x1011_6f42, 8)) goto l_0x1011_6f42;/* jz 0x10116f42 */
            ii(0x1011_6f3a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6f3d, 5);  call(Definitions.sys_delete, 0x4_f022);/* call 0x10165f64 */
        l_0x1011_6f42:
            ii(0x1011_6f42, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6f45, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_6f48, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_6f4b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_6f4d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_6f4e, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_6f4f, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_6f50, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_6f51, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_6f52, 1);  ret();                                /* ret */
        }
    }
}
