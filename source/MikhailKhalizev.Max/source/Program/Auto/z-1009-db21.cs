using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_db21-80f91e4")]
        public void Method_1009_db21()
        {
            ii(0x1009_db21, 5);  push(0x9c);                           /* push 0x9c */
            ii(0x1009_db26, 5);  call(Definitions.sys_check_available_stack_size, 0xc_8227);/* call 0x10165d52 */
            ii(0x1009_db2b, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_db2c, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_db2d, 1);  push(edx);                            /* push edx */
            ii(0x1009_db2e, 1);  push(esi);                            /* push esi */
            ii(0x1009_db2f, 1);  push(edi);                            /* push edi */
            ii(0x1009_db30, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_db31, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_db33, 6);  sub(esp, 0x74);                       /* sub esp, 0x74 */
            ii(0x1009_db39, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_db3c, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_db3f, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_7054);/* call 0x10076af0 */
            ii(0x1009_db44, 5);  mov(eax, memd[ds, 0x101c_8172]);      /* mov eax, [0x101c8172] */
            ii(0x1009_db49, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_db4c, 1);  push(eax);                            /* push eax */
            ii(0x1009_db4d, 6);  mov(ecx, memd[ds, 0x101c_8170]);      /* mov ecx, [0x101c8170] */
            ii(0x1009_db53, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1009_db56, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_db58, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_db5a, 3);  lea(eax, memd[ss, ebp - 88]);         /* lea eax, [ebp-0x58] */
            ii(0x1009_db5d, 5);  call(0x1008_b148, -0x1_2a1a);         /* call 0x1008b148 */
            ii(0x1009_db62, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_db65, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_707a);/* call 0x10076af0 */
            ii(0x1009_db6a, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1009_db6d, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_7082);/* call 0x10076af0 */
            ii(0x1009_db72, 3);  lea(edx, memd[ss, ebp - 60]);         /* lea edx, [ebp-0x3c] */
            ii(0x1009_db75, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_db78, 3);  mov(eax, memd[ds, eax + 27]);         /* mov eax, [eax+0x1b] */
            ii(0x1009_db7b, 5);  call(0x100a_0084, 0x2504);            /* call 0x100a0084 */
            ii(0x1009_db80, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_db82, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_db85, 5);  call(0x1008_8b44, -0x1_5046);         /* call 0x10088b44 */
            ii(0x1009_db8a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_db8d, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_db90, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_db93, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_db96, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_db99, 4);  mov(ax, memw[ds, eax + 37]);          /* mov ax, [eax+0x25] */
            ii(0x1009_db9d, 3);  sub(eax, memd[ss, ebp - 70]);         /* sub eax, [ebp-0x46] */
            ii(0x1009_dba0, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1009_dba3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dba6, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_dba9, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_dbac, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_dbaf, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_dbb2, 4);  mov(ax, memw[ds, eax + 35]);          /* mov ax, [eax+0x23] */
            ii(0x1009_dbb6, 3);  sub(eax, memd[ss, ebp - 72]);         /* sub eax, [ebp-0x48] */
            ii(0x1009_dbb9, 1);  cwde();                               /* cwde */
            ii(0x1009_dbba, 5);  call(0x1015_c339, 0xb_e77a);          /* call 0x1015c339 */
            ii(0x1009_dbbf, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_dbc2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dbc5, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_dbc8, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_dbcb, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_dbce, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_dbd1, 3);  add(edx, 0x23);                       /* add edx, 0x23 */
            ii(0x1009_dbd4, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_dbd6, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_dbd9, 5);  call(0x1008_8b44, -0x1_509a);         /* call 0x10088b44 */
            ii(0x1009_dbde, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1009_dbe1, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1009_dbe4, 5);  call(0x1008_8b44, -0x1_50a5);         /* call 0x10088b44 */
            ii(0x1009_dbe9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dbec, 4);  mov(ax, memw[ds, eax + 31]);          /* mov ax, [eax+0x1f] */
            ii(0x1009_dbf0, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_dbf3, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_dbf7, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_dbfa, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x1009_dbff, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_dc01, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_dc04, 5);  call(0x1008_b1a4, -0x1_2a65);         /* call 0x1008b1a4 */
        l_0x1009_dc09:
            ii(0x1009_dc09, 3);  dec(memd[ss, ebp - 20]);              /* dec dword [ebp-0x14] */
            ii(0x1009_dc0c, 5);  cmp(memw[ss, ebp - 20], -1 /* 0xff */);/* cmp word [ebp-0x14], 0xffff */
            ii(0x1009_dc11, 2);  if(jz(0x1009_dc22, 0xf)) goto l_0x1009_dc22;/* jz 0x1009dc22 */
            ii(0x1009_dc13, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1009_dc16, 3);  lea(eax, memd[ss, ebp - 88]);         /* lea eax, [ebp-0x58] */
            ii(0x1009_dc19, 5);  call(0x1010_82ce, 0x6_a6b0);          /* call 0x101082ce */
            ii(0x1009_dc1e, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_dc20, 2);  if(jnz(0x1009_dc24, 2)) goto l_0x1009_dc24;/* jnz 0x1009dc24 */
        l_0x1009_dc22:
            ii(0x1009_dc22, 2);  jmp(0x1009_dc5a, 0x36); goto l_0x1009_dc5a;/* jmp 0x1009dc5a */
        l_0x1009_dc24:
            ii(0x1009_dc24, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dc27, 4);  cmp(memb[ds, eax + 62], 0);           /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1009_dc2b, 2);  if(jnz(0x1009_dc58, 0x2b)) goto l_0x1009_dc58;/* jnz 0x1009dc58 */
            ii(0x1009_dc2d, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1009_dc32, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1009_dc37, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1009_dc3a, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1009_dc3d, 5);  call(0x1007_5e64, -0x2_7dde);         /* call 0x10075e64 */
            ii(0x1009_dc42, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_dc44, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dc47, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_dc4a, 5);  call(0x1008_abbc, -0x1_3093);         /* call 0x1008abbc */
            ii(0x1009_dc4f, 5);  call(0x100a_90f9, 0xb4a5);            /* call 0x100a90f9 */
            ii(0x1009_dc54, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_dc56, 2);  if(jnz(0x1009_dc5a, 2)) goto l_0x1009_dc5a;/* jnz 0x1009dc5a */
        l_0x1009_dc58:
            ii(0x1009_dc58, 2);  jmp(0x1009_dc5c, 2); goto l_0x1009_dc5c;/* jmp 0x1009dc5c */
        l_0x1009_dc5a:
            ii(0x1009_dc5a, 2);  jmp(0x1009_dc82, 0x26); goto l_0x1009_dc82;/* jmp 0x1009dc82 */
        l_0x1009_dc5c:
            ii(0x1009_dc5c, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1009_dc5f, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_dc62, 5);  call(0x1007_5e64, -0x2_7e03);         /* call 0x10075e64 */
            ii(0x1009_dc67, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1009_dc69, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dc6c, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_dc6f, 5);  call(0x1007_65d0, -0x2_76a4);         /* call 0x100765d0 */
            ii(0x1009_dc74, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_dc76, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dc79, 5);  call(0x1009_dfcf, 0x351);             /* call 0x1009dfcf */
            ii(0x1009_dc7e, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_dc80, 2);  if(jnz(0x1009_dc84, 2)) goto l_0x1009_dc84;/* jnz 0x1009dc84 */
        l_0x1009_dc82:
            ii(0x1009_dc82, 2);  jmp(0x1009_dcaa, 0x26); goto l_0x1009_dcaa;/* jmp 0x1009dcaa */
        l_0x1009_dc84:
            ii(0x1009_dc84, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1009_dc87, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1009_dc8a, 5);  call(0x1008_8b44, -0x1_514b);         /* call 0x10088b44 */
            ii(0x1009_dc8f, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_dc93, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_dc96, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x1009_dc9b, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_dc9d, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_dca0, 5);  call(0x1008_b1a4, -0x1_2b01);         /* call 0x1008b1a4 */
            ii(0x1009_dca5, 5);  jmp(0x1009_dc09, -0xa1); goto l_0x1009_dc09;/* jmp 0x1009dc09 */
        l_0x1009_dcaa:
            ii(0x1009_dcaa, 4);  or(memb[ss, ebp - 8], 1);             /* or byte [ebp-0x8], 0x1 */
            ii(0x1009_dcae, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_dcb1, 5);  call(0x1007_64fc, -0x2_77ba);         /* call 0x100764fc */
            ii(0x1009_dcb6, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1009_dcb9, 4);  and(memb[ss, ebp - 8], -2 /* 0xfe */);/* and byte [ebp-0x8], 0xfe */
            ii(0x1009_dcbd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dcc0, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_dcc3, 5);  call(0x1007_6574, -0x2_7754);         /* call 0x10076574 */
            ii(0x1009_dcc8, 4);  test(memb[ds, eax + 18], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1009_dccc, 2);  if(jz(0x1009_dce6, 0x18)) goto l_0x1009_dce6;/* jz 0x1009dce6 */
            ii(0x1009_dcce, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x1009_dcd3, 5);  call(0x1007_6338, -0x2_79a0);         /* call 0x10076338 */
            ii(0x1009_dcd8, 3);  lea(ebx, memd[ss, ebp - 48]);         /* lea ebx, [ebp-0x30] */
            ii(0x1009_dcdb, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_dcdd, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1009_dcdf, 5);  call(0x1007_643c, -0x2_78a8);         /* call 0x1007643c */
            ii(0x1009_dce4, 2);  jmp(0x1009_dcfc, 0x16); goto l_0x1009_dcfc;/* jmp 0x1009dcfc */
        l_0x1009_dce6:
            ii(0x1009_dce6, 5);  mov(eax, 0x101c_8184);                /* mov eax, 0x101c8184 */
            ii(0x1009_dceb, 5);  call(0x1007_6338, -0x2_79b8);         /* call 0x10076338 */
            ii(0x1009_dcf0, 3);  lea(ebx, memd[ss, ebp - 48]);         /* lea ebx, [ebp-0x30] */
            ii(0x1009_dcf3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_dcf5, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1009_dcf7, 5);  call(0x1007_643c, -0x2_78c0);         /* call 0x1007643c */
        l_0x1009_dcfc:
            ii(0x1009_dcfc, 2);  jmp(0x1009_dd06, 8); goto l_0x1009_dd06;/* jmp 0x1009dd06 */
        l_0x1009_dcfe:
            ii(0x1009_dcfe, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_dd01, 5);  call(0x1007_6bf8, -0x2_710e);         /* call 0x10076bf8 */
        l_0x1009_dd06:
            ii(0x1009_dd06, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_dd08, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_dd0b, 5);  call(0x1013_ad71, 0x9_d061);          /* call 0x1013ad71 */
            ii(0x1009_dd10, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_dd12, 6);  if(jz(0x1009_df21, 0x209)) goto l_0x1009_df21;/* jz 0x1009df21 */
            ii(0x1009_dd18, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_dd1b, 5);  call(0x1007_63a0, -0x2_7980);         /* call 0x100763a0 */
            ii(0x1009_dd20, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_dd22, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1009_dd25, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dd28, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_dd2b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_dd2e, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_dd30, 2);  if(jnz(0x1009_dd46, 0x14)) goto l_0x1009_dd46;/* jnz 0x1009dd46 */
            ii(0x1009_dd32, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_dd35, 5);  call(0x1007_63a0, -0x2_799a);         /* call 0x100763a0 */
            ii(0x1009_dd3a, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1009_dd3d, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_dd42, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_dd44, 2);  if(jg(0x1009_dd48, 2)) goto l_0x1009_dd48;/* jg 0x1009dd48 */
        l_0x1009_dd46:
            ii(0x1009_dd46, 2);  jmp(0x1009_dd67, 0x1f); goto l_0x1009_dd67;/* jmp 0x1009dd67 */
        l_0x1009_dd48:
            ii(0x1009_dd48, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_dd4b, 5);  call(0x1007_63a0, -0x2_79b0);         /* call 0x100763a0 */
            ii(0x1009_dd50, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_dd52, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dd55, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_dd58, 5);  call(0x1007_6574, -0x2_77e9);         /* call 0x10076574 */
            ii(0x1009_dd5d, 4);  mov(dx, memw[ds, edx + 8]);           /* mov dx, [edx+0x8] */
            ii(0x1009_dd61, 4);  cmp(dx, memw[ds, eax + 8]);           /* cmp dx, [eax+0x8] */
            ii(0x1009_dd65, 2);  if(jz(0x1009_dd69, 2)) goto l_0x1009_dd69;/* jz 0x1009dd69 */
        l_0x1009_dd67:
            ii(0x1009_dd67, 2);  jmp(0x1009_dd82, 0x19); goto l_0x1009_dd82;/* jmp 0x1009dd82 */
        l_0x1009_dd69:
            ii(0x1009_dd69, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_dd6c, 5);  call(0x1007_6408, -0x2_7969);         /* call 0x10076408 */
            ii(0x1009_dd71, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_dd73, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_dd76, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_dd79, 5);  call(0x1008_b4ec, -0x1_2892);         /* call 0x1008b4ec */
            ii(0x1009_dd7e, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_dd80, 2);  if(jnz(0x1009_dd87, 5)) goto l_0x1009_dd87;/* jnz 0x1009dd87 */
        l_0x1009_dd82:
            ii(0x1009_dd82, 5);  jmp(0x1009_df1c, 0x195); goto l_0x1009_df1c;/* jmp 0x1009df1c */
        l_0x1009_dd87:
            ii(0x1009_dd87, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_dd8a, 5);  call(0x1007_63a0, -0x2_79ef);         /* call 0x100763a0 */
            ii(0x1009_dd8f, 4);  cmp(memb[ds, eax + 61], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1009_dd93, 2);  if(jz(0x1009_dda3, 0xe)) goto l_0x1009_dda3;/* jz 0x1009dda3 */
            ii(0x1009_dd95, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_dd98, 5);  call(0x1007_63a0, -0x2_79fd);         /* call 0x100763a0 */
            ii(0x1009_dd9d, 4);  cmp(memb[ds, eax + 61], 0xc);         /* cmp byte [eax+0x3d], 0xc */
            ii(0x1009_dda1, 2);  if(jnz(0x1009_dda5, 2)) goto l_0x1009_dda5;/* jnz 0x1009dda5 */
        l_0x1009_dda3:
            ii(0x1009_dda3, 2);  jmp(0x1009_ddb3, 0xe); goto l_0x1009_ddb3;/* jmp 0x1009ddb3 */
        l_0x1009_dda5:
            ii(0x1009_dda5, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_dda8, 5);  call(0x1007_63a0, -0x2_7a0d);         /* call 0x100763a0 */
            ii(0x1009_ddad, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1009_ddb1, 2);  if(jnz(0x1009_ddb5, 2)) goto l_0x1009_ddb5;/* jnz 0x1009ddb5 */
        l_0x1009_ddb3:
            ii(0x1009_ddb3, 2);  jmp(0x1009_ddc3, 0xe); goto l_0x1009_ddc3;/* jmp 0x1009ddc3 */
        l_0x1009_ddb5:
            ii(0x1009_ddb5, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_ddb8, 5);  call(0x1007_63a0, -0x2_7a1d);         /* call 0x100763a0 */
            ii(0x1009_ddbd, 4);  cmp(memb[ds, eax + 61], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1009_ddc1, 2);  if(jnz(0x1009_de01, 0x3e)) goto l_0x1009_de01;/* jnz 0x1009de01 */
        l_0x1009_ddc3:
            ii(0x1009_ddc3, 3);  lea(edx, memd[ss, ebp - 64]);         /* lea edx, [ebp-0x40] */
            ii(0x1009_ddc6, 3);  lea(eax, memd[ss, ebp - 92]);         /* lea eax, [ebp-0x5c] */
            ii(0x1009_ddc9, 5);  call(0x1007_5e64, -0x2_7f6a);         /* call 0x10075e64 */
            ii(0x1009_ddce, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_ddd0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ddd3, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_ddd6, 5);  call(0x1007_65d0, -0x2_780b);         /* call 0x100765d0 */
            ii(0x1009_dddb, 5);  call(0x1007_0ca1, -0x2_d13f);         /* call 0x10070ca1 */
            ii(0x1009_dde0, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1009_dde2, 3);  lea(edx, memd[ss, ebp - 64]);         /* lea edx, [ebp-0x40] */
            ii(0x1009_dde5, 3);  lea(eax, memd[ss, ebp - 96]);         /* lea eax, [ebp-0x60] */
            ii(0x1009_dde8, 5);  call(0x1007_5e64, -0x2_7f89);         /* call 0x10075e64 */
            ii(0x1009_dded, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_ddef, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_ddf2, 5);  call(0x1007_63d4, -0x2_7a23);         /* call 0x100763d4 */
            ii(0x1009_ddf7, 5);  call(0x1007_0ca1, -0x2_d15b);         /* call 0x10070ca1 */
            ii(0x1009_ddfc, 3);  cmp(bx, ax);                          /* cmp bx, ax */
            ii(0x1009_ddff, 2);  if(jg(0x1009_de06, 5)) goto l_0x1009_de06;/* jg 0x1009de06 */
        l_0x1009_de01:
            ii(0x1009_de01, 5);  jmp(0x1009_df1c, 0x116); goto l_0x1009_df1c;/* jmp 0x1009df1c */
        l_0x1009_de06:
            ii(0x1009_de06, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_de0a, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_de0d, 5);  call(0x1007_63a0, -0x2_7a72);         /* call 0x100763a0 */
            ii(0x1009_de12, 5);  call(0x1015_26ac, 0xb_4895);          /* call 0x101526ac */
            ii(0x1009_de17, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_de19, 2);  if(jnz(0x1009_de21, 6)) goto l_0x1009_de21;/* jnz 0x1009de21 */
            ii(0x1009_de1b, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_de1f, 2);  jmp(0x1009_de6f, 0x4e); goto l_0x1009_de6f;/* jmp 0x1009de6f */
        l_0x1009_de21:
            ii(0x1009_de21, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_de24, 3);  mov(edx, memd[ds, eax + 11]);         /* mov edx, [eax+0xb] */
            ii(0x1009_de27, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_de2a, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_de2d, 5);  call(0x1007_63a0, -0x2_7a92);         /* call 0x100763a0 */
            ii(0x1009_de32, 5);  call(0x1015_26ac, 0xb_4875);          /* call 0x101526ac */
            ii(0x1009_de37, 5);  call(0x100a_2bc4, 0x4d88);            /* call 0x100a2bc4 */
            ii(0x1009_de3c, 1);  cwde();                               /* cwde */
            ii(0x1009_de3d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_de3f, 2);  if(jle(0x1009_de6f, 0x2e)) goto l_0x1009_de6f;/* jle 0x1009de6f */
            ii(0x1009_de41, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_de44, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_de47, 5);  call(0x1007_6574, -0x2_78d8);         /* call 0x10076574 */
            ii(0x1009_de4c, 5);  call(0x1015_26ac, 0xb_485b);          /* call 0x101526ac */
            ii(0x1009_de51, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x1009_de54, 3);  mov(eax, memd[ss, ebp - 100]);        /* mov eax, [ebp-0x64] */
            ii(0x1009_de57, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1009_de5a, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_de5d, 5);  call(0x1007_63d4, -0x2_7a8e);         /* call 0x100763d4 */
            ii(0x1009_de62, 3);  mov(ecx, memd[ss, ebp - 100]);        /* mov ecx, [ebp-0x64] */
            ii(0x1009_de65, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_de67, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1009_de69, 3);  call_abs(memd[ds, ebx + 4]);          /* call dword [ebx+0x4] */
            ii(0x1009_de6c, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
        l_0x1009_de6f:
            ii(0x1009_de6f, 4);  cmp(memb[ss, ebp - 12], 0);           /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1009_de73, 6);  if(jz(0x1009_df1c, 0xa3)) goto l_0x1009_df1c;/* jz 0x1009df1c */
            ii(0x1009_de79, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_de7c, 3);  add(edx, 0x13);                       /* add edx, 0x13 */
            ii(0x1009_de7f, 3);  lea(eax, memd[ss, ebp - 104]);        /* lea eax, [ebp-0x68] */
            ii(0x1009_de82, 5);  call(0x1007_6668, -0x2_781f);         /* call 0x10076668 */
            ii(0x1009_de87, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_de8a, 5);  call(0x1007_6408, -0x2_7a87);         /* call 0x10076408 */
            ii(0x1009_de8f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_de91, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_de94, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_de97, 5);  call(0x1007_6630, -0x2_786c);         /* call 0x10076630 */
            ii(0x1009_de9c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_de9f, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_dea2, 5);  call(0x1007_6574, -0x2_7933);         /* call 0x10076574 */
            ii(0x1009_dea7, 5);  call(0x1015_287d, 0xb_49d1);          /* call 0x1015287d */
            ii(0x1009_deac, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_deaf, 3);  mov(eax, memd[ds, eax + 27]);         /* mov eax, [eax+0x1b] */
            ii(0x1009_deb2, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
            ii(0x1009_deb5, 3);  mov(ebx, memd[ss, ebp - 108]);        /* mov ebx, [ebp-0x6c] */
            ii(0x1009_deb8, 3);  mov(ebx, memd[ds, ebx + 2]);          /* mov ebx, [ebx+0x2] */
            ii(0x1009_debb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_debe, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_dec1, 5);  call(0x1007_65d0, -0x2_78f6);         /* call 0x100765d0 */
            ii(0x1009_dec6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_dec8, 3);  mov(eax, memd[ss, ebp - 108]);        /* mov eax, [ebp-0x6c] */
            ii(0x1009_decb, 3);  call_abs(memd[ds, ebx + 44]);         /* call dword [ebx+0x2c] */
            ii(0x1009_dece, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_ded1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ded4, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_ded7, 5);  call(0x1007_6574, -0x2_7968);         /* call 0x10076574 */
            ii(0x1009_dedc, 5);  call(0x1015_27ed, 0xb_490c);          /* call 0x101527ed */
            ii(0x1009_dee1, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_dee3, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_dee6, 3);  lea(eax, memd[ss, ebp - 104]);        /* lea eax, [ebp-0x68] */
            ii(0x1009_dee9, 5);  call(0x1007_6574, -0x2_797a);         /* call 0x10076574 */
            ii(0x1009_deee, 5);  call(0x1015_2962, 0xb_4a6f);          /* call 0x10152962 */
            ii(0x1009_def3, 5);  call(0x1008_a79c, -0x1_375c);         /* call 0x1008a79c */
            ii(0x1009_def8, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_defa, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1009_defc, 3);  lea(eax, memd[ss, ebp - 104]);        /* lea eax, [ebp-0x68] */
            ii(0x1009_deff, 5);  call(0x1007_65d0, -0x2_7934);         /* call 0x100765d0 */
            ii(0x1009_df04, 5);  mov(ecx, 0x101c_3180);                /* mov ecx, 0x101c3180 */
            ii(0x1009_df09, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_df0b, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1009_df0d, 5);  call(0x100a_53ac, 0x749a);            /* call 0x100a53ac */
            ii(0x1009_df12, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_df14, 3);  lea(eax, memd[ss, ebp - 104]);        /* lea eax, [ebp-0x68] */
            ii(0x1009_df17, 5);  call(0x1007_5f2c, -0x2_7ff0);         /* call 0x10075f2c */
        l_0x1009_df1c:
            ii(0x1009_df1c, 5);  jmp(0x1009_dcfe, -0x223); goto l_0x1009_dcfe;/* jmp 0x1009dcfe */
        l_0x1009_df21:
            ii(0x1009_df21, 5);  mov(eax, 0x49);                       /* mov eax, 0x49 */
            ii(0x1009_df26, 5);  call(Definitions.sys_new, 0xc_7ed5);  /* call 0x10165e00 */
            ii(0x1009_df2b, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_df2e, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_df31, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_df34, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1009_df38, 2);  if(jz(0x1009_df8d, 0x53)) goto l_0x1009_df8d;/* jz 0x1009df8d */
            ii(0x1009_df3a, 5);  mov(eax, 0x1009_e075);                /* mov eax, 0x1009e075 */
            ii(0x1009_df3f, 1);  push(eax);                            /* push eax */
            ii(0x1009_df40, 3);  lea(edx, memd[ss, ebp - 64]);         /* lea edx, [ebp-0x40] */
            ii(0x1009_df43, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_df46, 5);  call(0x1007_5e64, -0x2_80e7);         /* call 0x10075e64 */
            ii(0x1009_df4b, 1);  push(eax);                            /* push eax */
            ii(0x1009_df4c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_df4f, 4);  cmp(memb[ds, eax + 62], 0);           /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1009_df53, 2);  if(jz(0x1009_df5b, 6)) goto l_0x1009_df5b;/* jz 0x1009df5b */
            ii(0x1009_df55, 4);  mov(memb[ss, ebp - 112], 0);          /* mov byte [ebp-0x70], 0x0 */
            ii(0x1009_df59, 2);  jmp(0x1009_df5f, 4); goto l_0x1009_df5f;/* jmp 0x1009df5f */
        l_0x1009_df5b:
            ii(0x1009_df5b, 4);  mov(memb[ss, ebp - 112], 3);          /* mov byte [ebp-0x70], 0x3 */
        l_0x1009_df5f:
            ii(0x1009_df5f, 3);  mov(eax, memd[ss, ebp - 115]);        /* mov eax, [ebp-0x73] */
            ii(0x1009_df62, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1009_df65, 1);  push(eax);                            /* push eax */
            ii(0x1009_df66, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1009_df68, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_df6b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_df6e, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_df71, 5);  call(0x1007_65d0, -0x2_79a6);         /* call 0x100765d0 */
            ii(0x1009_df76, 3);  mov(esi, memd[ss, ebp - 24]);         /* mov esi, [ebp-0x18] */
            ii(0x1009_df79, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_df7b, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1009_df7d, 5);  call(0x100a_c220, 0xe29e);            /* call 0x100ac220 */
            ii(0x1009_df82, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_df85, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1009_df88, 3);  mov(memd[ss, ebp - 116], eax);        /* mov [ebp-0x74], eax */
            ii(0x1009_df8b, 2);  jmp(0x1009_df93, 6); goto l_0x1009_df93;/* jmp 0x1009df93 */
        l_0x1009_df8d:
            ii(0x1009_df8d, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_df90, 3);  mov(memd[ss, ebp - 116], eax);        /* mov [ebp-0x74], eax */
        l_0x1009_df93:
            ii(0x1009_df93, 3);  mov(edx, memd[ss, ebp - 116]);        /* mov edx, [ebp-0x74] */
            ii(0x1009_df96, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1009_df99, 5);  call(0x1008_b060, -0x1_2f3e);         /* call 0x1008b060 */
            ii(0x1009_df9e, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1009_dfa1, 5);  call(0x1008_af84, -0x1_3022);         /* call 0x1008af84 */
            ii(0x1009_dfa6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_dfa8, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_dfad, 5);  call(0x100a_4d50, 0x6d9e);            /* call 0x100a4d50 */
            ii(0x1009_dfb2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_dfb4, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1009_dfb7, 5);  call(0x1008_8b7c, -0x1_5440);         /* call 0x10088b7c */
            ii(0x1009_dfbc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_dfbe, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_dfc1, 5);  call(0x1007_5f6c, -0x2_805a);         /* call 0x10075f6c */
            ii(0x1009_dfc6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_dfc8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_dfc9, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_dfca, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_dfcb, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_dfcc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_dfcd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_dfce, 1);  ret();                                /* ret */
        }
    }
}
