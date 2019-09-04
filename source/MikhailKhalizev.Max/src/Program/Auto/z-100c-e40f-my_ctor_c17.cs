using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_e40f-676b48b4")]
        public void my_ctor_c17()
        {
            ii(0x100c_e40f, 5); push(0x44);                             /* push 0x44 */
            ii(0x100c_e414, 5); call(Definitions.sys_check_available_stack_size, 0x9_7939); /* call 0x10165d52 */
            ii(0x100c_e419, 1); push(esi);                              /* push esi */
            ii(0x100c_e41a, 1); push(edi);                              /* push edi */
            ii(0x100c_e41b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_e41c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e41e, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100c_e424, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100c_e427, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100c_e42a, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100c_e42d, 3); mov(memd[ss, ebp - 8], ecx);            /* mov [ebp-0x8], ecx */
            ii(0x100c_e430, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e433, 5); call(0x100c_e2fc, -0x13c);              /* call 0x100ce2fc */
            ii(0x100c_e438, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_e43d, 5); call(Definitions.sys_new, 0x9_79be);    /* call 0x10165e00 */
            ii(0x100c_e442, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100c_e445, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_e448, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100c_e44b, 4); cmp(memd[ss, ebp - 24], 0);             /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_e44f, 2); if(jz(0x100c_e470, 0x1f)) goto l_0x100c_e470; /* jz 0x100ce470 */
            ii(0x100c_e451, 4); movsx(ecx, memw[ss, ebp + 16]);         /* movsx ecx, word [ebp+0x10] */
            ii(0x100c_e455, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x100c_e459, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100c_e45d, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_e460, 5); call(Definitions.my_ctor_c19, 0x97f9);  /* call 0x100d7c5e */
            ii(0x100c_e465, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100c_e468, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100c_e46b, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100c_e46e, 2); jmp(0x100c_e476, 6); goto l_0x100c_e476; /* jmp 0x100ce476 */
        l_0x100c_e470:
            ii(0x100c_e470, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100c_e473, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
        l_0x100c_e476:
            ii(0x100c_e476, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100c_e479, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100c_e47c, 3); mov(memd[ds, edx + 12], eax);           /* mov [edx+0xc], eax */
            ii(0x100c_e47f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e482, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x100c_e485, 5); call(0x100d_4ef0, 0x6a66);              /* call 0x100d4ef0 */
            ii(0x100c_e48a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_e48c, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e48f, 4); mov(memw[ds, eax + 4], dx);             /* mov [eax+0x4], dx */
            ii(0x100c_e493, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e496, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x100c_e499, 5); call(0x100d_4ebc, 0x6a1e);              /* call 0x100d4ebc */
            ii(0x100c_e49e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_e4a0, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e4a3, 4); mov(memw[ds, eax + 6], dx);             /* mov [eax+0x6], dx */
            ii(0x100c_e4a7, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e4aa, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x100c_e4ad, 5); call(0x100d_4f58, 0x6aa6);              /* call 0x100d4f58 */
            ii(0x100c_e4b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_e4b4, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e4b7, 4); mov(memw[ds, eax + 8], dx);             /* mov [eax+0x8], dx */
            ii(0x100c_e4bb, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e4be, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x100c_e4c1, 5); call(0x100d_4f24, 0x6a5e);              /* call 0x100d4f24 */
            ii(0x100c_e4c6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_e4c8, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e4cb, 4); mov(memw[ds, eax + 10], dx);            /* mov [eax+0xa], dx */
            ii(0x100c_e4cf, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_e4d4, 5); call(Definitions.sys_new, 0x9_7927);    /* call 0x10165e00 */
            ii(0x100c_e4d9, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100c_e4dc, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100c_e4df, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100c_e4e2, 4); cmp(memd[ss, ebp - 40], 0);             /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100c_e4e6, 2); if(jz(0x100c_e511, 0x29)) goto l_0x100c_e511; /* jz 0x100ce511 */
            ii(0x100c_e4e8, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e4eb, 3); mov(ecx, memd[ds, eax + 4]);            /* mov ecx, [eax+0x4] */
            ii(0x100c_e4ee, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_e4f1, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e4f4, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x100c_e4f7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_e4fa, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100c_e4fe, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100c_e501, 5); call(Definitions.my_ctor_c19, 0x9758);  /* call 0x100d7c5e */
            ii(0x100c_e506, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x100c_e509, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x100c_e50c, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x100c_e50f, 2); jmp(0x100c_e517, 6); goto l_0x100c_e517; /* jmp 0x100ce517 */
        l_0x100c_e511:
            ii(0x100c_e511, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100c_e514, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
        l_0x100c_e517:
            ii(0x100c_e517, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x100c_e51a, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100c_e51d, 3); mov(memd[ds, edx + 16], eax);           /* mov [edx+0x10], eax */
            ii(0x100c_e520, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e523, 4); mov(memb[ds, eax + 40], 1);             /* mov byte [eax+0x28], 0x1 */
            ii(0x100c_e527, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e52a, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x100c_e52d, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x100c_e530, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e532, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_e533, 1); pop(edi);                               /* pop edi */
            ii(0x100c_e534, 1); pop(esi);                               /* pop esi */
            ii(0x100c_e535, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
