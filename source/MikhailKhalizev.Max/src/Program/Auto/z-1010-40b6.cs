using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_40b6-d3b467f9")]
        public void Method_1010_40b6()
        {
            ii(0x1010_40b6, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1010_40bb, 5); call(Definitions.sys_check_available_stack_size, 0x6_1c92); /* call 0x10165d52 */
            ii(0x1010_40c0, 1); push(ebx);                              /* push ebx */
            ii(0x1010_40c1, 1); push(ecx);                              /* push ecx */
            ii(0x1010_40c2, 1); push(esi);                              /* push esi */
            ii(0x1010_40c3, 1); push(edi);                              /* push edi */
            ii(0x1010_40c4, 1); push(ebp);                              /* push ebp */
            ii(0x1010_40c5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_40c7, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_40cd, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_40d0, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_40d3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_40d6, 5); call(0x1010_3ff1, -0xea);               /* call 0x10103ff1 */
            ii(0x1010_40db, 3); lea(edx, memd[ss, ebp - 12]);           /* lea edx, [ebp-0xc] */
            ii(0x1010_40de, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_40e1, 5); call(0x1013_bb7b, 0x3_7a95);            /* call 0x1013bb7b */
            ii(0x1010_40e6, 5); mov(eax, 0x101b_56fc);                  /* mov eax, 0x101b56fc */
            ii(0x1010_40eb, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_40ee, 3); mov(ebx, memd[ds, edx + 2]);            /* mov ebx, [edx+0x2] */
            ii(0x1010_40f1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_40f3, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_40f5, 5); call(Definitions.sys_call_dtor_arr, 0x6_1ebe); /* call 0x10165fb8 */
            ii(0x1010_40fa, 5); call(Definitions.sys_delete_arr, 0x6_1ed9); /* call 0x10165fd8 */
            ii(0x1010_40ff, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_4102, 4); mov(memw[ss, ebp - 16], ax);            /* mov [ebp-0x10], ax */
            ii(0x1010_4106, 5); mov(ebx, 0x101b_56fc);                  /* mov ebx, 0x101b56fc */
            ii(0x1010_410b, 3); mov(edx, memd[ss, ebp - 18]);           /* mov edx, [ebp-0x12] */
            ii(0x1010_410e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_4111, 3); mov(eax, memd[ss, ebp - 18]);           /* mov eax, [ebp-0x12] */
            ii(0x1010_4114, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_4117, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1010_411a, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1010_411d, 5); call(Definitions.sys_new_arr, 0x6_1eee); /* call 0x10166010 */
            ii(0x1010_4122, 5); call(Definitions.sys_call_ctor_arr, 0x6_dcd8); /* call 0x10171dff */
            ii(0x1010_4127, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_412a, 3); mov(memd[ds, edx + 2], eax);            /* mov [edx+0x2], eax */
            ii(0x1010_412d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_4130, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_4133, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1010_4136, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x1010_413d, 2); jmp(0x1010_4145, 6); goto l_0x1010_4145; /* jmp 0x10104145 */
        l_0x1010_413f:
            ii(0x1010_413f, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1010_4142, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
        l_0x1010_4145:
            ii(0x1010_4145, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1010_4148, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_414b, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x1010_414e, 2); if(jge(0x1010_4169, 0x19)) goto l_0x1010_4169; /* jge 0x10104169 */
            ii(0x1010_4150, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1010_4153, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1010_4157, 3); imul(ebx, eax, 0xa);                    /* imul ebx, eax, 0xa */
            ii(0x1010_415a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_415d, 3); mov(eax, memd[ds, eax + 2]);            /* mov eax, [eax+0x2] */
            ii(0x1010_4160, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_4162, 5); call(0x1010_2cbf, -0x14a8);             /* call 0x10102cbf */
            ii(0x1010_4167, 2); jmp(0x1010_413f, -0x2a); goto l_0x1010_413f; /* jmp 0x1010413f */
        l_0x1010_4169:
            ii(0x1010_4169, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_416b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_416c, 1); pop(edi);                               /* pop edi */
            ii(0x1010_416d, 1); pop(esi);                               /* pop esi */
            ii(0x1010_416e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_416f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_4170, 1); ret();                                  /* ret */
        }
    }
}
