using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_da84-5c31be24")]
        public void /* sys */ Method_1016_da84()
        {
            ii(0x1016_da84, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_da85, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_da86, 1);  push(edx);                            /* push edx */
            ii(0x1016_da87, 1);  push(esi);                            /* push esi */
            ii(0x1016_da88, 1);  push(edi);                            /* push edi */
            ii(0x1016_da89, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_da8a, 6);  mov(ecx, memd[ds, 0x1020_8534]);      /* mov ecx, [0x10208534] */
            ii(0x1016_da90, 6);  mov(ebx, memd[ds, 0x1020_8568]);      /* mov ebx, [0x10208568] */
            ii(0x1016_da96, 5);  mov(eax, memd[ds, 0x1020_8564]);      /* mov eax, [0x10208564] */
            ii(0x1016_da9b, 6);  mov(esi, memd[ds, 0x1020_8544]);      /* mov esi, [0x10208544] */
            ii(0x1016_daa1, 6);  mov(edi, memd[ds, 0x1020_8530]);      /* mov edi, [0x10208530] */
            ii(0x1016_daa7, 5);  mov(memd[ds, 0x1020_856c], eax);      /* mov [0x1020856c], eax */
            ii(0x1016_daac, 5);  mov(eax, memd[ds, 0x1020_8554]);      /* mov eax, [0x10208554] */
            ii(0x1016_dab1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_dab3, 5);  mov(memd[ds, 0x1020_8550], eax);      /* mov [0x10208550], eax */
            ii(0x1016_dab8, 5);  mov(eax, memd[ds, 0x1020_8528]);      /* mov eax, [0x10208528] */
            ii(0x1016_dabd, 2);  add(ecx, ecx);                        /* add ecx, ecx */
            ii(0x1016_dabf, 5);  mov(memd[ds, 0x1020_8538], eax);      /* mov [0x10208538], eax */
            ii(0x1016_dac4, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1016_dac9, 2);  cmp(ebx, edi);                        /* cmp ebx, edi */
            ii(0x1016_dacb, 6);  if(jge(0x1016_db43, 0x72)) goto l_0x1016_db43;/* jge 0x1016db43 */
            ii(0x1016_dad1, 6);  mov(memd[ds, 0x1020_8884], esi);      /* mov [0x10208884], esi */
        l_0x1016_dad7:
            ii(0x1016_dad7, 5);  call(/* sys */ 0x1016_dc08, 0x12c);   /* call 0x1016dc08 */
            ii(0x1016_dadc, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_dade, 2);  if(jz(0x1016_daed, 0xd)) goto l_0x1016_daed;/* jz 0x1016daed */
            ii(0x1016_dae0, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1016_dae5, 6);  mov(esi, memd[ds, 0x1020_8884]);      /* mov esi, [0x10208884] */
            ii(0x1016_daeb, 2);  jmp(0x1016_daf7, 0xa); goto l_0x1016_daf7;/* jmp 0x1016daf7 */
        l_0x1016_daed:
            ii(0x1016_daed, 6);  mov(esi, memd[ds, 0x1020_8884]);      /* mov esi, [0x10208884] */
            ii(0x1016_daf3, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1016_daf5, 2);  if(jnz(0x1016_db43, 0x4c)) goto l_0x1016_db43;/* jnz 0x1016db43 */
        l_0x1016_daf7:
            ii(0x1016_daf7, 5);  mov(eax, memd[ds, 0x1020_8540]);      /* mov eax, [0x10208540] */
            ii(0x1016_dafc, 6);  mov(ebp, memd[ds, 0x1020_8550]);      /* mov ebp, [0x10208550] */
            ii(0x1016_db02, 6);  mov(edi, memd[ds, 0x1020_8538]);      /* mov edi, [0x10208538] */
            ii(0x1016_db08, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1016_db0b, 1);  inc(ebx);                             /* inc ebx */
            ii(0x1016_db0c, 2);  add(ebp, eax);                        /* add ebp, eax */
            ii(0x1016_db0e, 5);  mov(eax, memd[ds, 0x1020_8540]);      /* mov eax, [0x10208540] */
            ii(0x1016_db13, 6);  mov(memd[ds, 0x1020_8550], ebp);      /* mov [0x10208550], ebp */
            ii(0x1016_db19, 2);  add(edi, eax);                        /* add edi, eax */
            ii(0x1016_db1b, 6);  mov(ebp, memd[ds, 0x1020_856c]);      /* mov ebp, [0x1020856c] */
            ii(0x1016_db21, 6);  mov(memd[ds, 0x1020_8538], edi);      /* mov [0x10208538], edi */
            ii(0x1016_db27, 2);  add(ebp, esi);                        /* add ebp, esi */
            ii(0x1016_db29, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1016_db2b, 6);  mov(edi, memd[ds, 0x1020_8530]);      /* mov edi, [0x10208530] */
            ii(0x1016_db31, 2);  add(esi, ecx);                        /* add esi, ecx */
            ii(0x1016_db33, 6);  mov(memd[ds, 0x1020_856c], ebp);      /* mov [0x1020856c], ebp */
            ii(0x1016_db39, 6);  mov(memd[ds, 0x1020_8884], esi);      /* mov [0x10208884], esi */
            ii(0x1016_db3f, 2);  cmp(ebx, edi);                        /* cmp ebx, edi */
            ii(0x1016_db41, 2);  if(jl(0x1016_dad7, -0x6c)) goto l_0x1016_dad7;/* jl 0x1016dad7 */
        l_0x1016_db43:
            ii(0x1016_db43, 6);  mov(esi, memd[ds, 0x1020_8544]);      /* mov esi, [0x10208544] */
            ii(0x1016_db49, 5);  mov(eax, memd[ds, 0x1020_8564]);      /* mov eax, [0x10208564] */
            ii(0x1016_db4e, 2);  sub(esi, ecx);                        /* sub esi, ecx */
            ii(0x1016_db50, 6);  mov(edi, memd[ds, 0x1020_8540]);      /* mov edi, [0x10208540] */
            ii(0x1016_db56, 2);  sub(eax, esi);                        /* sub eax, esi */
            ii(0x1016_db58, 3);  shl(edi, 2);                          /* shl edi, 0x2 */
            ii(0x1016_db5b, 5);  mov(memd[ds, 0x1020_856c], eax);      /* mov [0x1020856c], eax */
            ii(0x1016_db60, 5);  mov(eax, memd[ds, 0x1020_8554]);      /* mov eax, [0x10208554] */
            ii(0x1016_db65, 6);  mov(ebx, memd[ds, 0x1020_8568]);      /* mov ebx, [0x10208568] */
            ii(0x1016_db6b, 2);  sub(eax, edi);                        /* sub eax, edi */
            ii(0x1016_db6d, 6);  mov(ebp, memd[ds, 0x1020_8540]);      /* mov ebp, [0x10208540] */
            ii(0x1016_db73, 5);  mov(memd[ds, 0x1020_8550], eax);      /* mov [0x10208550], eax */
            ii(0x1016_db78, 5);  mov(eax, memd[ds, 0x1020_8528]);      /* mov eax, [0x10208528] */
            ii(0x1016_db7d, 1);  dec(ebx);                             /* dec ebx */
            ii(0x1016_db7e, 2);  sub(eax, ebp);                        /* sub eax, ebp */
            ii(0x1016_db80, 6);  mov(memd[ds, 0x1020_8884], esi);      /* mov [0x10208884], esi */
            ii(0x1016_db86, 5);  mov(memd[ds, 0x1020_8538], eax);      /* mov [0x10208538], eax */
            ii(0x1016_db8b, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1016_db90, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1016_db92, 2);  if(jl(0x1016_dbf6, 0x62)) goto l_0x1016_dbf6;/* jl 0x1016dbf6 */
        l_0x1016_db94:
            ii(0x1016_db94, 5);  call(/* sys */ 0x1016_dc08, 0x6f);    /* call 0x1016dc08 */
            ii(0x1016_db99, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_db9b, 2);  if(jz(0x1016_dba4, 7)) goto l_0x1016_dba4;/* jz 0x1016dba4 */
            ii(0x1016_db9d, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1016_dba2, 2);  jmp(0x1016_dba8, 4); goto l_0x1016_dba8;/* jmp 0x1016dba8 */
        l_0x1016_dba4:
            ii(0x1016_dba4, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1016_dba6, 2);  if(jnz(0x1016_dbf6, 0x4e)) goto l_0x1016_dbf6;/* jnz 0x1016dbf6 */
        l_0x1016_dba8:
            ii(0x1016_dba8, 5);  mov(eax, memd[ds, 0x1020_8540]);      /* mov eax, [0x10208540] */
            ii(0x1016_dbad, 6);  mov(esi, memd[ds, 0x1020_8550]);      /* mov esi, [0x10208550] */
            ii(0x1016_dbb3, 6);  mov(edi, memd[ds, 0x1020_8538]);      /* mov edi, [0x10208538] */
            ii(0x1016_dbb9, 6);  mov(ebp, memd[ds, 0x1020_856c]);      /* mov ebp, [0x1020856c] */
            ii(0x1016_dbbf, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1016_dbc2, 1);  dec(ebx);                             /* dec ebx */
            ii(0x1016_dbc3, 2);  sub(esi, eax);                        /* sub esi, eax */
            ii(0x1016_dbc5, 5);  mov(eax, memd[ds, 0x1020_8540]);      /* mov eax, [0x10208540] */
            ii(0x1016_dbca, 6);  mov(memd[ds, 0x1020_8550], esi);      /* mov [0x10208550], esi */
            ii(0x1016_dbd0, 6);  mov(esi, memd[ds, 0x1020_8884]);      /* mov esi, [0x10208884] */
            ii(0x1016_dbd6, 2);  sub(edi, eax);                        /* sub edi, eax */
            ii(0x1016_dbd8, 2);  sub(esi, ecx);                        /* sub esi, ecx */
            ii(0x1016_dbda, 6);  mov(memd[ds, 0x1020_8538], edi);      /* mov [0x10208538], edi */
            ii(0x1016_dbe0, 6);  mov(memd[ds, 0x1020_8884], esi);      /* mov [0x10208884], esi */
            ii(0x1016_dbe6, 2);  sub(ebp, esi);                        /* sub ebp, esi */
            ii(0x1016_dbe8, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1016_dbea, 6);  mov(memd[ds, 0x1020_856c], ebp);      /* mov [0x1020856c], ebp */
            ii(0x1016_dbf0, 2);  xor(eax, esi);                        /* xor eax, esi */
            ii(0x1016_dbf2, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1016_dbf4, 2);  if(jge(0x1016_db94, -0x62)) goto l_0x1016_db94;/* jge 0x1016db94 */
        l_0x1016_dbf6:
            ii(0x1016_dbf6, 6);  mov(esi, memd[ds, 0x1020_8884]);      /* mov esi, [0x10208884] */
            ii(0x1016_dbfc, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_dbfe, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_dbff, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_dc00, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_dc01, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_dc02, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_dc03, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_dc04, 1);  ret();                                /* ret */
        }
    }
}
