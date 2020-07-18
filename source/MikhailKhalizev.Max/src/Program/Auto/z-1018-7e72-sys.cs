using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7e72-e0113320")]
        public void /* sys */ Method_1018_7e72()
        {
            ii(0x1018_7e72, 1);  push(esi);                            /* push esi */
            ii(0x1018_7e73, 1);  push(edi);                            /* push edi */
            ii(0x1018_7e74, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_7e75, 1);  push(edx);                            /* push edx */
            ii(0x1018_7e76, 1);  pushd(es);                            /* push es */
            ii(0x1018_7e77, 2);  mov(edx, eax);                        /* mov edx, eax */
        l_0x1018_7e79:
            ii(0x1018_7e79, 6);  mov(esi, 0x101c_2f92);                /* mov esi, 0x101c2f92 */
            ii(0x1018_7e7f, 6);  mov(edi, 0x101c_3052);                /* mov edi, 0x101c3052 */
            ii(0x1018_7e85, 2);  mov(ebx, edi);                        /* mov ebx, edi */
            ii(0x1018_7e87, 2);  mov(al, dl);                          /* mov al, dl */
        l_0x1018_7e89:
            ii(0x1018_7e89, 2);  cmp(esi, edi);                        /* cmp esi, edi */
            ii(0x1018_7e8b, 2);  if(jae(0x1018_7ea1, 0x14)) goto l_0x1018_7ea1;/* jae 0x10187ea1 */
            ii(0x1018_7e8d, 3);  cmp(memb[ds, esi], 2);                /* cmp byte [esi], 0x2 */
            ii(0x1018_7e90, 2);  if(jz(0x1018_7e9c, 0xa)) goto l_0x1018_7e9c;/* jz 0x10187e9c */
            ii(0x1018_7e92, 3);  cmp(memb[ds, esi + 1], al);           /* cmp [esi+0x1], al */
            ii(0x1018_7e95, 2);  if(ja(0x1018_7e9c, 5)) goto l_0x1018_7e9c;/* ja 0x10187e9c */
            ii(0x1018_7e97, 2);  mov(ebx, esi);                        /* mov ebx, esi */
            ii(0x1018_7e99, 3);  mov(al, memb[ds, esi + 1]);           /* mov al, [esi+0x1] */
        l_0x1018_7e9c:
            ii(0x1018_7e9c, 3);  add(esi, 6);                          /* add esi, 0x6 */
            ii(0x1018_7e9f, 2);  jmp(0x1018_7e89, -0x18); goto l_0x1018_7e89;/* jmp 0x10187e89 */
        l_0x1018_7ea1:
            ii(0x1018_7ea1, 2);  cmp(ebx, edi);                        /* cmp ebx, edi */
            ii(0x1018_7ea3, 2);  if(jz(0x1018_7eb7, 0x12)) goto l_0x1018_7eb7;/* jz 0x10187eb7 */
            ii(0x1018_7ea5, 3);  mov(eax, memd[ds, ebx + 2]);          /* mov eax, [ebx+0x2] */
            ii(0x1018_7ea8, 2);  or(eax, eax);                         /* or eax, eax */
            ii(0x1018_7eaa, 2);  if(jz(0x1018_7eb2, 6)) goto l_0x1018_7eb2;/* jz 0x10187eb2 */
            ii(0x1018_7eac, 1);  pushd(ds);                            /* push ds */
            ii(0x1018_7ead, 1);  popd(es);                             /* pop es */
            ii(0x1018_7eae, 1);  push(edx);                            /* push edx */
            ii(0x1018_7eaf, 2);  call_abs(eax);                        /* call eax */
            ii(0x1018_7eb1, 1);  pop(edx);                             /* pop edx */
        l_0x1018_7eb2:
            ii(0x1018_7eb2, 3);  mov(memb[ds, ebx], 2);                /* mov byte [ebx], 0x2 */
            ii(0x1018_7eb5, 2);  jmp(0x1018_7e79, -0x3e); goto l_0x1018_7e79;/* jmp 0x10187e79 */
        l_0x1018_7eb7:
            ii(0x1018_7eb7, 1);  popd(es);                             /* pop es */
            ii(0x1018_7eb8, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_7eb9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_7eba, 1);  pop(edi);                             /* pop edi */
            ii(0x1018_7ebb, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_7ebc, 1);  ret();                                /* ret */
        }
    }
}
