using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_e1ae-c59b0110")]
        public void Method_1013_e1ae()
        {
            ii(0x1013_e1ae, 5);  push(0xb8);                           /* push 0xb8 */
            ii(0x1013_e1b3, 5);  call(Definitions.sys_check_available_stack_size, 0x2_7b9a);/* call 0x10165d52 */
            ii(0x1013_e1b8, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_e1b9, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_e1ba, 1);  push(esi);                            /* push esi */
            ii(0x1013_e1bb, 1);  push(edi);                            /* push edi */
            ii(0x1013_e1bc, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_e1bd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_e1bf, 6);  sub(esp, 0xa0);                       /* sub esp, 0xa0 */
            ii(0x1013_e1c5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_e1c8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_e1cb, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_e1cf, 5);  call(Definitions.my_get_res_data_by_id_malloc, -0x9fe9);/* call 0x101341eb */
            ii(0x1013_e1d4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_e1d7, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1013_e1db, 2);  if(jnz(0x1013_e1e9, 0xc)) goto l_0x1013_e1e9;/* jnz 0x1013e1e9 */
            ii(0x1013_e1dd, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_e1e4, 5);  jmp(0x1013_e336, 0x14d); goto l_0x1013_e336;/* jmp 0x1013e336 */
        l_0x1013_e1e9:
            ii(0x1013_e1e9, 5);  mov(edx, 0x101c_402c);                /* mov edx, 0x101c402c */
            ii(0x1013_e1ee, 3);  lea(eax, memd[ss, ebp - 116]);        /* lea eax, [ebp-0x74] */
            ii(0x1013_e1f1, 5);  call(Definitions.sys_strcpy, 0x2_7cd9);/* call 0x10165ecf */
            ii(0x1013_e1f6, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_e1f9, 3);  lea(eax, memd[ss, ebp - 116]);        /* lea eax, [ebp-0x74] */
            ii(0x1013_e1fc, 5);  call(Definitions.sys_strcat, 0x2_7d30);/* call 0x10165f31 */
            ii(0x1013_e201, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_e204, 5);  call(Definitions.sys_delete, 0x2_7d5b);/* call 0x10165f64 */
            ii(0x1013_e209, 5);  mov(edx, StringDefinitions.Rb3);      /* mov edx, 0x101acd3b */
            ii(0x1013_e20e, 3);  lea(eax, memd[ss, ebp - 116]);        /* lea eax, [ebp-0x74] */
            ii(0x1013_e211, 5);  call(Definitions.my_fopen, -0x4_edf7);/* call 0x100ef41f */
            ii(0x1013_e216, 3);  mov(memd[ss, ebp - 120], eax);        /* mov [ebp-0x78], eax */
            ii(0x1013_e219, 4);  cmp(memd[ss, ebp - 120], 0);          /* cmp dword [ebp-0x78], 0x0 */
            ii(0x1013_e21d, 2);  if(jnz(0x1013_e22b, 0xc)) goto l_0x1013_e22b;/* jnz 0x1013e22b */
            ii(0x1013_e21f, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_e226, 5);  jmp(0x1013_e336, 0x10b); goto l_0x1013_e336;/* jmp 0x1013e336 */
        l_0x1013_e22b:
            ii(0x1013_e22b, 3);  mov(ecx, memd[ss, ebp - 120]);        /* mov ecx, [ebp-0x78] */
            ii(0x1013_e22e, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1013_e233, 5);  mov(edx, 4);                          /* mov edx, 0x4 */
            ii(0x1013_e238, 6);  lea(eax, memd[ss, ebp - 156]);        /* lea eax, [ebp-0x9c] */
            ii(0x1013_e23e, 5);  call(Definitions.my_fread, -0x4_edb4);/* call 0x100ef48f */
            ii(0x1013_e243, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_e245, 2);  if(jnz(0x1013_e25b, 0x14)) goto l_0x1013_e25b;/* jnz 0x1013e25b */
            ii(0x1013_e247, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x1013_e24a, 5);  call(Definitions.sys_fclose, 0x3_3e1a);/* call 0x10172069 */
            ii(0x1013_e24f, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_e256, 5);  jmp(0x1013_e336, 0xdb); goto l_0x1013_e336;/* jmp 0x1013e336 */
        l_0x1013_e25b:
            ii(0x1013_e25b, 5);  mov(ebx, 4);                          /* mov ebx, 0x4 */
            ii(0x1013_e260, 5);  mov(edx, StringDefinitions.Riff);     /* mov edx, 0x101acd3e */
            ii(0x1013_e265, 6);  lea(eax, memd[ss, ebp - 156]);        /* lea eax, [ebp-0x9c] */
            ii(0x1013_e26b, 5);  call(Definitions.sys_strncmp, 0x3_aeec);/* call 0x1017915c */
            ii(0x1013_e270, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_e272, 2);  if(jnz(0x1013_e2d4, 0x60)) goto l_0x1013_e2d4;/* jnz 0x1013e2d4 */
            ii(0x1013_e274, 3);  mov(ecx, memd[ss, ebp - 120]);        /* mov ecx, [ebp-0x78] */
            ii(0x1013_e277, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1013_e27c, 5);  mov(edx, 0x20);                       /* mov edx, 0x20 */
            ii(0x1013_e281, 6);  lea(eax, memd[ss, ebp - 152]);        /* lea eax, [ebp-0x98] */
            ii(0x1013_e287, 5);  call(Definitions.my_fread, -0x4_edfd);/* call 0x100ef48f */
            ii(0x1013_e28c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_e28e, 2);  if(jnz(0x1013_e2a4, 0x14)) goto l_0x1013_e2a4;/* jnz 0x1013e2a4 */
            ii(0x1013_e290, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x1013_e293, 5);  call(Definitions.sys_fclose, 0x3_3dd1);/* call 0x10172069 */
            ii(0x1013_e298, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_e29f, 5);  jmp(0x1013_e336, 0x92); goto l_0x1013_e336;/* jmp 0x1013e336 */
        l_0x1013_e2a4:
            ii(0x1013_e2a4, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1013_e2a9, 6);  mov(edx, memd[ss, ebp - 140]);        /* mov edx, [ebp-0x8c] */
            ii(0x1013_e2af, 3);  sub(edx, 0xc);                        /* sub edx, 0xc */
            ii(0x1013_e2b2, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x1013_e2b5, 5);  call(Definitions.my_fseek, -0x4_ee65);/* call 0x100ef455 */
            ii(0x1013_e2ba, 3);  mov(ecx, memd[ss, ebp - 120]);        /* mov ecx, [ebp-0x78] */
            ii(0x1013_e2bd, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1013_e2c2, 5);  mov(edx, 4);                          /* mov edx, 0x4 */
            ii(0x1013_e2c7, 6);  lea(eax, memd[ss, ebp - 160]);        /* lea eax, [ebp-0xa0] */
            ii(0x1013_e2cd, 5);  call(Definitions.my_fread, -0x4_ee43);/* call 0x100ef48f */
            ii(0x1013_e2d2, 2);  jmp(0x1013_e2dd, 9); goto l_0x1013_e2dd;/* jmp 0x1013e2dd */
        l_0x1013_e2d4:
            ii(0x1013_e2d4, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_e2db, 2);  jmp(0x1013_e336, 0x59); goto l_0x1013_e336;/* jmp 0x1013e336 */
        l_0x1013_e2dd:
            ii(0x1013_e2dd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e2e0, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x1013_e2e3, 5);  call(Definitions.sys_fclose, 0x3_3d81);/* call 0x10172069 */
            ii(0x1013_e2e8, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x1013_e2eb, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_e2ee, 3);  mov(memd[ds, edx + 8], eax);          /* mov [edx+0x8], eax */
            ii(0x1013_e2f1, 6);  mov(eax, memd[ss, ebp - 160]);        /* mov eax, [ebp-0xa0] */
            ii(0x1013_e2f7, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_e2fa, 6);  mov(memd[ds, edx + 3530], eax);       /* mov [edx+0xdca], eax */
            ii(0x1013_e300, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x1013_e303, 5);  call(Definitions.sys_ftell, 0x3_443f);/* call 0x10172747 */
            ii(0x1013_e308, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1013_e30a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e30d, 6);  mov(memd[ds, eax + 3525], edx);       /* mov [eax+0xdc5], edx */
            ii(0x1013_e313, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e316, 6);  mov(edx, memd[ds, eax + 3530]);       /* mov edx, [eax+0xdca] */
            ii(0x1013_e31c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_e31f, 6);  mov(memd[ds, eax + 3534], edx);       /* mov [eax+0xdce], edx */
            ii(0x1013_e325, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_e328, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_e32b, 4);  mov(memw[ds, edx + 12], ax);          /* mov [edx+0xc], ax */
            ii(0x1013_e32f, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
        l_0x1013_e336:
            ii(0x1013_e336, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_e339, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_e33b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_e33c, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_e33d, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_e33e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_e33f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_e340, 1);  ret();                                /* ret */
        }
    }
}
