using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_604c-5271df7c")]
        public void Method_1012_604c()
        {
            ii(0x1012_604c, 5); push(0x30);                             /* push 0x30 */
            ii(0x1012_6051, 5); call(Definitions.sys_check_available_stack_size, 0x3_fcfc); /* call 0x10165d52 */
            ii(0x1012_6056, 1); push(ebx);                              /* push ebx */
            ii(0x1012_6057, 1); push(ecx);                              /* push ecx */
            ii(0x1012_6058, 1); push(esi);                              /* push esi */
            ii(0x1012_6059, 1); push(edi);                              /* push edi */
            ii(0x1012_605a, 1); push(ebp);                              /* push ebp */
            ii(0x1012_605b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_605d, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1012_6063, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_6066, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1012_6069, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_606c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1012_606f, 3); lea(edx, memd[ss, ebp - 20]);           /* lea edx, [ebp-0x14] */
            ii(0x1012_6072, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_6075, 5); call(0x1015_0a5f, 0x2_a9e5);            /* call 0x10150a5f */
            ii(0x1012_607a, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_607d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_6080, 5); call(0x1012_5f31, -0x154);              /* call 0x10125f31 */
            ii(0x1012_6085, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_6088, 5); call(0x100d_5440, -0x5_0c4d);           /* call 0x100d5440 */
            ii(0x1012_608d, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1012_608f, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_6092, 3); mov(memb[ds, eax + 13], dl);            /* mov [eax+0xd], dl */
            ii(0x1012_6095, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_6098, 3); mov(dl, memb[ds, eax + 69]);            /* mov dl, [eax+0x45] */
            ii(0x1012_609b, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_609e, 3); mov(memb[ds, eax + 14], dl);            /* mov [eax+0xe], dl */
            ii(0x1012_60a1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_60a4, 5); call(0x1009_c9a0, -0x8_9709);           /* call 0x1009c9a0 */
            ii(0x1012_60a9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_60ab, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_60ae, 3); mov(memb[ds, eax + 15], dl);            /* mov [eax+0xf], dl */
            ii(0x1012_60b1, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1012_60b4, 5); call(Definitions.my_2_get_count, -0x9_ad51); /* call 0x1008b368 */
            ii(0x1012_60b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_60bb, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_60be, 4); mov(memw[ds, eax + 16], dx);            /* mov [eax+0x10], dx */
            ii(0x1012_60c2, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_60c9, 2); jmp(0x1012_60d1, 6); goto l_0x1012_60d1; /* jmp 0x101260d1 */
        l_0x1012_60cb:
            ii(0x1012_60cb, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_60ce, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
        l_0x1012_60d1:
            ii(0x1012_60d1, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_60d4, 3); mov(edx, memd[ss, ebp - 24]);           /* mov edx, [ebp-0x18] */
            ii(0x1012_60d7, 4); cmp(ax, memw[ds, edx + 16]);            /* cmp ax, [edx+0x10] */
            ii(0x1012_60db, 2); if(jge(0x1012_60fb, 0x1e)) goto l_0x1012_60fb; /* jge 0x101260fb */
            ii(0x1012_60dd, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x1012_60e1, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1012_60e4, 5); call(0x1008_b228, -0x9_aec1);           /* call 0x1008b228 */
            ii(0x1012_60e9, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x1012_60ed, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1012_60ef, 3); add(edx, memd[ss, ebp - 24]);           /* add edx, [ebp-0x18] */
            ii(0x1012_60f2, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1012_60f5, 4); mov(memw[ds, edx + 18], ax);            /* mov [edx+0x12], ax */
            ii(0x1012_60f9, 2); jmp(0x1012_60cb, -0x30); goto l_0x1012_60cb; /* jmp 0x101260cb */
        l_0x1012_60fb:
            ii(0x1012_60fb, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_60fe, 4); mov(ax, memw[ds, eax + 16]);            /* mov ax, [eax+0x10] */
            ii(0x1012_6102, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_6104, 5); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1012_6109, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1012_610c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_610e, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1012_6111, 5); call(0x1008_8b04, -0x9_d612);           /* call 0x10088b04 */
            ii(0x1012_6116, 2); jmp(0x1012_6122, 0xa); goto l_0x1012_6122; /* jmp 0x10126122 */
        //  ii(0x1012_6118, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1012_611a, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
        //  ii(0x1012_611d, 5); call(0x1008_8b04, -0x9_d61e);           /* call 0x10088b04 */
        l_0x1012_6122:
            ii(0x1012_6122, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_6125, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_6127, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_6128, 1); pop(edi);                               /* pop edi */
            ii(0x1012_6129, 1); pop(esi);                               /* pop esi */
            ii(0x1012_612a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_612b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_612c, 1); ret();                                  /* ret */
        }
    }
}
