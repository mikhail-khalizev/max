using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a8b0-6ed6cbfb")]
        public void Method_1009_a8b0()
        {
            ii(0x1009_a8b0, 5);  push(0x50);                           /* push 0x50 */
            ii(0x1009_a8b5, 5);  call(Definitions.sys_check_available_stack_size, 0xc_b498);/* call 0x10165d52 */
            ii(0x1009_a8ba, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_a8bb, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_a8bc, 1);  push(esi);                            /* push esi */
            ii(0x1009_a8bd, 1);  push(edi);                            /* push edi */
            ii(0x1009_a8be, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_a8bf, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_a8c1, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x1009_a8c7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_a8ca, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_a8cd, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_a8d0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a8d3, 5);  call(0x1015_2a52, 0xb_817a);          /* call 0x10152a52 */
            ii(0x1009_a8d8, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_a8da, 2);  if(jnz(0x1009_a8e5, 9)) goto l_0x1009_a8e5;/* jnz 0x1009a8e5 */
            ii(0x1009_a8dc, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_a8e0, 5);  jmp(0x1009_ab4c, 0x267); goto l_0x1009_ab4c;/* jmp 0x1009ab4c */
        l_0x1009_a8e5:
            ii(0x1009_a8e5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_a8e7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a8ea, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a8ed, 5);  call(0x1013_ad71, 0xa_047f);          /* call 0x1013ad71 */
            ii(0x1009_a8f2, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_a8f4, 2);  if(jz(0x1009_a933, 0x3d)) goto l_0x1009_a933;/* jz 0x1009a933 */
            ii(0x1009_a8f6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a8f9, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a8fc, 5);  call(0x1007_6574, -0x2_438d);         /* call 0x10076574 */
            ii(0x1009_a901, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1009_a904, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1009_a907, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a90a, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a90d, 5);  call(0x1007_6574, -0x2_439e);         /* call 0x10076574 */
            ii(0x1009_a912, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1009_a915, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_a918, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a91b, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1009_a91e, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1009_a920, 1);  cwde();                               /* cwde */
            ii(0x1009_a921, 5);  call(0x1007_41dc, -0x2_674a);         /* call 0x100741dc */
            ii(0x1009_a926, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_a928, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a92b, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a92e, 5);  call(0x1007_6630, -0x2_4303);         /* call 0x10076630 */
        l_0x1009_a933:
            ii(0x1009_a933, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_a935, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a938, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a93b, 5);  call(0x1013_ad11, 0xa_03d1);          /* call 0x1013ad11 */
            ii(0x1009_a940, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_a942, 2);  if(jnz(0x1009_a988, 0x44)) goto l_0x1009_a988;/* jnz 0x1009a988 */
            ii(0x1009_a944, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1009_a949, 5);  mov(esi, 3);                          /* mov esi, 0x3 */
            ii(0x1009_a94e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a951, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a954, 5);  call(0x1007_6574, -0x2_43e5);         /* call 0x10076574 */
            ii(0x1009_a959, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1009_a95c, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1009_a95f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a962, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a965, 5);  call(0x1007_6574, -0x2_43f6);         /* call 0x10076574 */
            ii(0x1009_a96a, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1009_a96d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_a970, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_a973, 5);  call(0x1007_6aac, -0x2_3ecc);         /* call 0x10076aac */
            ii(0x1009_a978, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_a97a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a97d, 2);  mov(ebx, esi);                        /* mov ebx, esi */
            ii(0x1009_a97f, 5);  call(0x100a_90f9, 0xe775);            /* call 0x100a90f9 */
            ii(0x1009_a984, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_a986, 2);  if(jz(0x1009_a999, 0x11)) goto l_0x1009_a999;/* jz 0x1009a999 */
        l_0x1009_a988:
            ii(0x1009_a988, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a98b, 5);  call(0x1009_a476, -0x51a);            /* call 0x1009a476 */
            ii(0x1009_a990, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_a994, 5);  jmp(0x1009_ab4c, 0x1b3); goto l_0x1009_ab4c;/* jmp 0x1009ab4c */
        l_0x1009_a999:
            ii(0x1009_a999, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a99c, 5);  call(0x1007_623c, -0x2_4765);         /* call 0x1007623c */
            ii(0x1009_a9a1, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_a9a4, 4);  mov(dx, memw[ds, edx + 82]);          /* mov dx, [edx+0x52] */
            ii(0x1009_a9a8, 4);  cmp(dx, memw[ds, eax + 25]);          /* cmp dx, [eax+0x19] */
            ii(0x1009_a9ac, 2);  if(jnz(0x1009_a9c1, 0x13)) goto l_0x1009_a9c1;/* jnz 0x1009a9c1 */
            ii(0x1009_a9ae, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_a9b1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a9b4, 5);  call(0x1009_a57f, -0x43a);            /* call 0x1009a57f */
            ii(0x1009_a9b9, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1009_a9bc, 5);  jmp(0x1009_ab4c, 0x18b); goto l_0x1009_ab4c;/* jmp 0x1009ab4c */
        l_0x1009_a9c1:
            ii(0x1009_a9c1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a9c4, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a9c7, 5);  call(0x1007_6574, -0x2_4458);         /* call 0x10076574 */
            ii(0x1009_a9cc, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_a9cf, 4);  mov(dx, memw[ds, edx + 26]);          /* mov dx, [edx+0x1a] */
            ii(0x1009_a9d3, 4);  cmp(dx, memw[ds, eax + 26]);          /* cmp dx, [eax+0x1a] */
            ii(0x1009_a9d7, 2);  if(jnz(0x1009_a9f1, 0x18)) goto l_0x1009_a9f1;/* jnz 0x1009a9f1 */
            ii(0x1009_a9d9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a9dc, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a9df, 5);  call(0x1007_6574, -0x2_4470);         /* call 0x10076574 */
            ii(0x1009_a9e4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_a9e7, 4);  mov(dx, memw[ds, edx + 28]);          /* mov dx, [edx+0x1c] */
            ii(0x1009_a9eb, 4);  cmp(dx, memw[ds, eax + 28]);          /* cmp dx, [eax+0x1c] */
            ii(0x1009_a9ef, 2);  if(jz(0x1009_a9f6, 5)) goto l_0x1009_a9f6;/* jz 0x1009a9f6 */
        l_0x1009_a9f1:
            ii(0x1009_a9f1, 5);  jmp(0x1009_aa6d, 0x77); goto l_0x1009_aa6d;/* jmp 0x1009aa6d */
        l_0x1009_a9f6:
            ii(0x1009_a9f6, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1009_a9f8, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x1009_a9fd, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_a9ff, 2);  if(jnz(0x1009_aa16, 0x15)) goto l_0x1009_aa16;/* jnz 0x1009aa16 */
            ii(0x1009_aa01, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_aa04, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_aa07, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_aa0a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_aa0c, 6);  mov(dl, memb[ds, 0x101c_37c8]);       /* mov dl, [0x101c37c8] */
            ii(0x1009_aa12, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_aa14, 2);  if(jnz(0x1009_aa64, 0x4e)) goto l_0x1009_aa64;/* jnz 0x1009aa64 */
        l_0x1009_aa16:
            ii(0x1009_aa16, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_aa19, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_aa1c, 5);  call(0x1007_65d0, -0x2_4451);         /* call 0x100765d0 */
            ii(0x1009_aa21, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_aa23, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_aa26, 5);  call(0x1008_a998, -0x1_0093);         /* call 0x1008a998 */
            ii(0x1009_aa2b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_aa2e, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_aa31, 5);  call(0x1007_6574, -0x2_44c2);         /* call 0x10076574 */
            ii(0x1009_aa36, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1009_aa3a, 2);  if(jz(0x1009_aa45, 9)) goto l_0x1009_aa45;/* jz 0x1009aa45 */
            ii(0x1009_aa3c, 7);  mov(memd[ss, ebp - 40], 4);           /* mov dword [ebp-0x28], 0x4 */
            ii(0x1009_aa43, 2);  jmp(0x1009_aa4c, 7); goto l_0x1009_aa4c;/* jmp 0x1009aa4c */
        l_0x1009_aa45:
            ii(0x1009_aa45, 7);  mov(memd[ss, ebp - 40], 1);           /* mov dword [ebp-0x28], 0x1 */
        l_0x1009_aa4c:
            ii(0x1009_aa4c, 3);  mov(al, memb[ss, ebp - 40]);          /* mov al, [ebp-0x28] */
            ii(0x1009_aa4f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_aa52, 3);  mov(memb[ds, edx + 69], al);          /* mov [edx+0x45], al */
            ii(0x1009_aa55, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_aa57, 5);  mov(edx, 0xb);                        /* mov edx, 0xb */
            ii(0x1009_aa5c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_aa5f, 5);  call(0x1016_3053, 0xc_85ef);          /* call 0x10163053 */
        l_0x1009_aa64:
            ii(0x1009_aa64, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_aa68, 5);  jmp(0x1009_ab4c, 0xdf); goto l_0x1009_ab4c;/* jmp 0x1009ab4c */
        l_0x1009_aa6d:
            ii(0x1009_aa6d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_aa70, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1009_aa73, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_aa78, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_aa7a, 2);  if(jnz(0x1009_aa85, 9)) goto l_0x1009_aa85;/* jnz 0x1009aa85 */
            ii(0x1009_aa7c, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_aa80, 5);  jmp(0x1009_ab4c, 0xc7); goto l_0x1009_ab4c;/* jmp 0x1009ab4c */
        l_0x1009_aa85:
            ii(0x1009_aa85, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1009_aa8a, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_aa8d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_aa90, 5);  call(0x100a_3671, 0x8bdc);            /* call 0x100a3671 */
            ii(0x1009_aa95, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_aa97, 2);  if(jz(0x1009_aaa2, 9)) goto l_0x1009_aaa2;/* jz 0x1009aaa2 */
            ii(0x1009_aa99, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_aa9d, 5);  jmp(0x1009_ab4c, 0xaa); goto l_0x1009_ab4c;/* jmp 0x1009ab4c */
        l_0x1009_aaa2:
            ii(0x1009_aaa2, 5);  mov(eax, 0x49);                       /* mov eax, 0x49 */
            ii(0x1009_aaa7, 5);  call(Definitions.sys_new, 0xc_b354);  /* call 0x10165e00 */
            ii(0x1009_aaac, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_aaaf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_aab2, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1009_aab5, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1009_aab9, 2);  if(jz(0x1009_ab0d, 0x52)) goto l_0x1009_ab0d;/* jz 0x1009ab0d */
            ii(0x1009_aabb, 5);  mov(eax, 0x1009_a542);                /* mov eax, 0x1009a542 */
            ii(0x1009_aac0, 1);  push(eax);                            /* push eax */
            ii(0x1009_aac1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_aac4, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_aac7, 5);  call(0x1007_6574, -0x2_4558);         /* call 0x10076574 */
            ii(0x1009_aacc, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1009_aacf, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1009_aad2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_aad5, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_aad8, 5);  call(0x1007_6574, -0x2_4569);         /* call 0x10076574 */
            ii(0x1009_aadd, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1009_aae0, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_aae3, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_aae6, 5);  call(0x1007_6aac, -0x2_403f);         /* call 0x10076aac */
            ii(0x1009_aaeb, 1);  push(eax);                            /* push eax */
            ii(0x1009_aaec, 5);  mov(eax, 3);                          /* mov eax, 0x3 */
            ii(0x1009_aaf1, 1);  push(eax);                            /* push eax */
            ii(0x1009_aaf2, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1009_aaf4, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1009_aaf7, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_aafa, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_aafd, 5);  call(0x100a_c220, 0x1_171e);          /* call 0x100ac220 */
            ii(0x1009_ab02, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_ab05, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_ab08, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1009_ab0b, 2);  jmp(0x1009_ab13, 6); goto l_0x1009_ab13;/* jmp 0x1009ab13 */
        l_0x1009_ab0d:
            ii(0x1009_ab0d, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_ab10, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
        l_0x1009_ab13:
            ii(0x1009_ab13, 3);  mov(edx, memd[ss, ebp - 44]);         /* mov edx, [ebp-0x2c] */
            ii(0x1009_ab16, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_ab19, 5);  call(0x1008_b060, -0xfabe);           /* call 0x1008b060 */
            ii(0x1009_ab1e, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_ab21, 5);  call(0x1008_af84, -0xfba2);           /* call 0x1008af84 */
            ii(0x1009_ab26, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_ab28, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_ab2d, 5);  call(0x100a_4d50, 0xa21e);            /* call 0x100a4d50 */
            ii(0x1009_ab32, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_ab36, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_ab38, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_ab3b, 5);  call(0x1008_8b7c, -0x1_1fc4);         /* call 0x10088b7c */
            ii(0x1009_ab40, 2);  jmp(0x1009_ab4c, 0xa); goto l_0x1009_ab4c;/* jmp 0x1009ab4c */
        //  ii(0x1009_ab42, 10);  Недостижимый код.
        l_0x1009_ab4c:
            ii(0x1009_ab4c, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1009_ab4f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_ab51, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_ab52, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_ab53, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_ab54, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_ab55, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_ab56, 1);  ret();                                /* ret */
        }
    }
}
