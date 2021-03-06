using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6ad6-f16ab3b5")]
        public void Method_1013_6ad6()
        {
            ii(0x1013_6ad6, 5);  push(0x64);                           /* push 0x64 */
            ii(0x1013_6adb, 5);  call(Definitions.sys_check_available_stack_size, 0x2_f272);/* call 0x10165d52 */
            ii(0x1013_6ae0, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_6ae1, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_6ae2, 1);  push(edx);                            /* push edx */
            ii(0x1013_6ae3, 1);  push(esi);                            /* push esi */
            ii(0x1013_6ae4, 1);  push(edi);                            /* push edi */
            ii(0x1013_6ae5, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_6ae6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_6ae8, 6);  sub(esp, 0x44);                       /* sub esp, 0x44 */
            ii(0x1013_6aee, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_6af1, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x1013_6af6, 5);  call(Definitions.sys_new, 0x2_f305);  /* call 0x10165e00 */
            ii(0x1013_6afb, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_6afe, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_6b01, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_6b04, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1013_6b08, 2);  if(jz(0x1013_6b42, 0x38)) goto l_0x1013_6b42;/* jz 0x10136b42 */
            ii(0x1013_6b0a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6b0d, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x1013_6b10, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_6b13, 1);  push(eax);                            /* push eax */
            ii(0x1013_6b14, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6b17, 3);  mov(ecx, memd[ds, eax + 10]);         /* mov ecx, [eax+0xa] */
            ii(0x1013_6b1a, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1013_6b1d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6b20, 3);  mov(ebx, memd[ds, eax + 6]);          /* mov ebx, [eax+0x6] */
            ii(0x1013_6b23, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1013_6b26, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6b29, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1013_6b2c, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1013_6b2f, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_6b32, 5);  call(0x100d_7bdc, -0x5_ef5b);         /* call 0x100d7bdc */
            ii(0x1013_6b37, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_6b3a, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1013_6b3d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_6b40, 2);  jmp(0x1013_6b48, 6); goto l_0x1013_6b48;/* jmp 0x10136b48 */
        l_0x1013_6b42:
            ii(0x1013_6b42, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_6b45, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x1013_6b48:
            ii(0x1013_6b48, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_6b4b, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_6b4e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6b51, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_6b53, 3);  mov(memd[ss, ebp - 50], eax);         /* mov [ebp-0x32], eax */
            ii(0x1013_6b56, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6b59, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_6b5b, 5);  call(/* sys */ 0x1016_7dd4, 0x3_1274);/* call 0x10167dd4 */
            ii(0x1013_6b60, 3);  mov(memd[ss, ebp - 46], eax);         /* mov [ebp-0x2e], eax */
            ii(0x1013_6b63, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6b66, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_6b68, 5);  call(/* sys */ 0x1016_7e3c, 0x3_12cf);/* call 0x10167e3c */
            ii(0x1013_6b6d, 4);  mov(memw[ss, ebp - 52], ax);          /* mov [ebp-0x34], ax */
            ii(0x1013_6b71, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1013_6b74, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_6b77, 5);  call(0x100d_7d74, -0x5_ee08);         /* call 0x100d7d74 */
            ii(0x1013_6b7c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6b7f, 3);  mov(eax, memd[ds, eax + 28]);         /* mov eax, [eax+0x1c] */
            ii(0x1013_6b82, 5);  call(/* sys */ 0x1016_965c, 0x3_2ad5);/* call 0x1016965c */
            ii(0x1013_6b87, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1013_6b8a, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_6b8d, 5);  call(0x100d_7f6c, -0x5_ec26);         /* call 0x100d7f6c */
            ii(0x1013_6b92, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_6b95, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_6b98, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1013_6b9c, 2);  if(jz(0x1013_6bb2, 0x14)) goto l_0x1013_6bb2;/* jz 0x10136bb2 */
            ii(0x1013_6b9e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_6ba0, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_6ba3, 5);  call(Definitions.my_dtor_d3, -0x5_ee75);/* call 0x100d7d33 */
            ii(0x1013_6ba8, 5);  call(Definitions.sys_delete, 0x2_f3b7);/* call 0x10165f64 */
            ii(0x1013_6bad, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_6bb0, 2);  jmp(0x1013_6bb9, 7); goto l_0x1013_6bb9;/* jmp 0x10136bb9 */
        l_0x1013_6bb2:
            ii(0x1013_6bb2, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
        l_0x1013_6bb9:
            ii(0x1013_6bb9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6bbc, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x1013_6bbf, 5);  call(Definitions.sys_delete, 0x2_f3a0);/* call 0x10165f64 */
            ii(0x1013_6bc4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6bc7, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1013_6bca, 5);  call(Definitions.sys_delete, 0x2_f395);/* call 0x10165f64 */
            ii(0x1013_6bcf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6bd2, 3);  mov(eax, memd[ds, eax + 79]);         /* mov eax, [eax+0x4f] */
            ii(0x1013_6bd5, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_6bd8, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_6bdc, 2);  if(jz(0x1013_6bf2, 0x14)) goto l_0x1013_6bf2;/* jz 0x10136bf2 */
            ii(0x1013_6bde, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_6be0, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_6be3, 5);  call(Definitions.my_dtor_d6, -0x4_bb11);/* call 0x100eb0d7 */
            ii(0x1013_6be8, 5);  call(Definitions.sys_delete, 0x2_f377);/* call 0x10165f64 */
            ii(0x1013_6bed, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_6bf0, 2);  jmp(0x1013_6bf9, 7); goto l_0x1013_6bf9;/* jmp 0x10136bf9 */
        l_0x1013_6bf2:
            ii(0x1013_6bf2, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
        l_0x1013_6bf9:
            ii(0x1013_6bf9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_6bfb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_6bfc, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_6bfd, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_6bfe, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_6bff, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_6c00, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_6c01, 1);  ret();                                /* ret */
        }
    }
}
