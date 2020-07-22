using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_cec7-bfc0e2f7")]
        public void Method_1013_cec7()
        {
            ii(0x1013_cec7, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1013_cecc, 5);  call(Definitions.sys_check_available_stack_size, 0x2_8e81);/* call 0x10165d52 */
            ii(0x1013_ced1, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_ced2, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_ced3, 1);  push(edx);                            /* push edx */
            ii(0x1013_ced4, 1);  push(esi);                            /* push esi */
            ii(0x1013_ced5, 1);  push(edi);                            /* push edi */
            ii(0x1013_ced6, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_ced7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_ced9, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1013_cedf, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_cee2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_cee5, 7);  cmp(memd[ds, eax + 28], 0xffff);      /* cmp dword [eax+0x1c], 0xffff */
            ii(0x1013_ceec, 6);  if(jz(0x1013_cf85, 0x93)) goto l_0x1013_cf85;/* jz 0x1013cf85 */
            ii(0x1013_cef2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_cef5, 10);  cmp(memd[ds, eax + 3497], 0xffff);   /* cmp dword [eax+0xda9], 0xffff */
            ii(0x1013_ceff, 2);  if(jz(0x1013_cf0f, 0xe)) goto l_0x1013_cf0f;/* jz 0x1013cf0f */
            ii(0x1013_cf01, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_cf04, 6);  mov(eax, memd[ds, eax + 3497]);       /* mov eax, [eax+0xda9] */
            ii(0x1013_cf0a, 5);  call(/* sys */ 0x1017_dc61, 0x4_0d52);/* call 0x1017dc61 */
        l_0x1013_cf0f:
            ii(0x1013_cf0f, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1013_cf11, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_cf13, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_cf16, 3);  mov(eax, memd[ds, eax + 28]);         /* mov eax, [eax+0x1c] */
            ii(0x1013_cf19, 5);  call(/* sys */ 0x1017_f8aa, 0x4_298c);/* call 0x1017f8aa */
            ii(0x1013_cf1e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_cf21, 3);  add(edx, 0x1c);                       /* add edx, 0x1c */
            ii(0x1013_cf24, 2);  mov(eax, ds);                         /* mov eax, ds */
            ii(0x1013_cf26, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x1013_cf2b, 1);  push(eax);                            /* push eax */
            ii(0x1013_cf2c, 1);  push(edx);                            /* push edx */
            ii(0x1013_cf2d, 2);  mov(eax, ds);                         /* mov eax, ds */
            ii(0x1013_cf2f, 5);  mov(edx, 0x101b_d4ec);                /* mov edx, 0x101bd4ec */
            ii(0x1013_cf34, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x1013_cf39, 1);  push(eax);                            /* push eax */
            ii(0x1013_cf3a, 1);  push(edx);                            /* push edx */
            ii(0x1013_cf3b, 2);  mov(eax, ds);                         /* mov eax, ds */
            ii(0x1013_cf3d, 5);  mov(edx, 0x101c_80fc);                /* mov edx, 0x101c80fc */
            ii(0x1013_cf42, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1013_cf44, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_cf46, 6);  mov(edx, memd[ds, 0x101c_80f4]);      /* mov edx, [0x101c80f4] */
            ii(0x1013_cf4c, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1013_cf4e, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1013_cf50, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_cf52, 5);  call(/* sys */ 0x1017_f04e, 0x4_20f7);/* call 0x1017f04e */
            ii(0x1013_cf57, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_cf5a, 6);  add(edx, 0xda9);                      /* add edx, 0xda9 */
            ii(0x1013_cf60, 2);  mov(eax, ds);                         /* mov eax, ds */
            ii(0x1013_cf62, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x1013_cf67, 1);  push(eax);                            /* push eax */
            ii(0x1013_cf68, 1);  push(edx);                            /* push edx */
            ii(0x1013_cf69, 7);  mov(bx, memw[ds, 0x101b_d50c]);       /* mov bx, [0x101bd50c] */
            ii(0x1013_cf70, 5);  mov(eax, memd[ds, 0x101b_d508]);      /* mov eax, [0x101bd508] */
            ii(0x1013_cf75, 5);  mov(edx, 0x28);                       /* mov edx, 0x28 */
            ii(0x1013_cf7a, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1013_cf7c, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1013_cf7e, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_cf80, 5);  call(/* sys */ 0x1017_d93f, 0x4_09ba);/* call 0x1017d93f */
        l_0x1013_cf85:
            ii(0x1013_cf85, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_cf87, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_cf88, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_cf89, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_cf8a, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_cf8b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_cf8c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_cf8d, 1);  ret();                                /* ret */
        }
    }
}
