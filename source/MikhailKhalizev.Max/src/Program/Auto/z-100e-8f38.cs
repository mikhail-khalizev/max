using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8f38-f441cf1e")]
        public void Method_100e_8f38()
        {
            ii(0x100e_8f38, 5); pushd(0x50);                            /* push 0x50 */
            ii(0x100e_8f3d, 5); calld(Definitions.sys_check_available_stack_size, 0x7_ce10); /* call 0x10165d52 */
            ii(0x100e_8f42, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_8f43, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_8f44, 1); pushd(esi);                             /* push esi */
            ii(0x100e_8f45, 1); pushd(edi);                             /* push edi */
            ii(0x100e_8f46, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_8f47, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_8f49, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100e_8f4f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_8f52, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_8f55, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_8f58, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_8f5b, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_8f5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_8f61, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_8f63, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_8f66, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_8f69, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x100e_8f6c, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_8f6f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_8f71, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_8f74, 3); idiv(memd_a32[ss, ebp - 0x4]);          /* idiv dword [ebp-0x4] */
            ii(0x100e_8f77, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_8f7a, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100e_8f7d, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_8f80, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_8f82, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_8f85, 3); idiv(memd_a32[ss, ebp - 0x4]);          /* idiv dword [ebp-0x4] */
            ii(0x100e_8f88, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_8f8b, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_8f8e, 4); imul(eax, memd_a32[ss, ebp - 0x1c]);    /* imul eax, [ebp-0x1c] */
            ii(0x100e_8f92, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100e_8f95, 5); calld(Definitions.sys_malloc, 0x8_2044); /* call 0x1016afde */
            ii(0x100e_8f9a, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_8f9d, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_8fa0, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x100e_8fa3, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x100e_8fa6, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_8fa9, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x100e_8fac, 4); mov(memw_a32[ds, edx + 0x2], ax);       /* mov [edx+0x2], ax */
            ii(0x100e_8fb0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_8fb3, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100e_8fb6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_8fb9, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_8fbc, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_8fbe, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_8fc1, 3); idiv(memd_a32[ss, ebp - 0x4]);          /* idiv dword [ebp-0x4] */
            ii(0x100e_8fc4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_8fc6, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100e_8fc9, 4); mov(memw_a32[ds, eax + 0x4], dx);       /* mov [eax+0x4], dx */
            ii(0x100e_8fcd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_8fd0, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100e_8fd3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_8fd6, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_8fd9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_8fdb, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_8fde, 3); idiv(memd_a32[ss, ebp - 0x4]);          /* idiv dword [ebp-0x4] */
            ii(0x100e_8fe1, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x100e_8fe4, 4); mov(memw_a32[ds, edx + 0x6], ax);       /* mov [edx+0x6], ax */
            ii(0x100e_8fe8, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100e_8feb, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100e_8fee, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_8ff1, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x100e_8ff4, 1); dec(edx);                               /* dec edx */
            ii(0x100e_8ff5, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_8ff8, 3); mov(ebx, memd_a32[ss, ebp - 0x20]);     /* mov ebx, [ebp-0x20] */
            ii(0x100e_8ffb, 1); dec(ebx);                               /* dec ebx */
            ii(0x100e_8ffc, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_8ffe, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_9001, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_9003, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100e_9006, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_9009, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100e_900c, 1); dec(edx);                               /* dec edx */
            ii(0x100e_900d, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_9010, 3); mov(ebx, memd_a32[ss, ebp - 0x1c]);     /* mov ebx, [ebp-0x1c] */
            ii(0x100e_9013, 1); dec(ebx);                               /* dec ebx */
            ii(0x100e_9014, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_9016, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_9019, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_901b, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100e_901e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_9021, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
            ii(0x100e_9028, 2); jmpd(0x100e_9030, 0x6); goto l_0x100e_9030; /* jmp 0x100e9030 */
        l_0x100e_902a:
            ii(0x100e_902a, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_902d, 3); inc(memd_a32[ss, ebp - 0x30]);          /* inc dword [ebp-0x30] */
        l_0x100e_9030:
            ii(0x100e_9030, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_9033, 3); cmp(eax, memd_a32[ss, ebp - 0x1c]);     /* cmp eax, [ebp-0x1c] */
            ii(0x100e_9036, 2); if(jged(0x100e_9085, 0x4d)) goto l_0x100e_9085; /* jge 0x100e9085 */
            ii(0x100e_9038, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_903b, 4); imul(eax, memd_a32[ss, ebp - 0xc]);     /* imul eax, [ebp-0xc] */
            ii(0x100e_903f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_9042, 4); imul(eax, memd_a32[ss, ebp - 0x28]);    /* imul eax, [ebp-0x28] */
            ii(0x100e_9046, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_9049, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x100e_904c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_904e, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x100e_9051, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100e_9058, 2); jmpd(0x100e_9060, 0x6); goto l_0x100e_9060; /* jmp 0x100e9060 */
        l_0x100e_905a:
            ii(0x100e_905a, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_905d, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
        l_0x100e_9060:
            ii(0x100e_9060, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_9063, 3); cmp(eax, memd_a32[ss, ebp - 0x20]);     /* cmp eax, [ebp-0x20] */
            ii(0x100e_9066, 2); if(jged(0x100e_9083, 0x1b)) goto l_0x100e_9083; /* jge 0x100e9083 */
            ii(0x100e_9068, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_906b, 4); imul(eax, memd_a32[ss, ebp - 0x10]);    /* imul eax, [ebp-0x10] */
            ii(0x100e_906f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_9072, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_9075, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_9077, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_907a, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
            ii(0x100e_907d, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x100e_907f, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x100e_9081, 2); jmpd(0x100e_905a, -0x29); goto l_0x100e_905a; /* jmp 0x100e905a */
        l_0x100e_9083:
            ii(0x100e_9083, 2); jmpd(0x100e_902a, -0x5b); goto l_0x100e_902a; /* jmp 0x100e902a */
        l_0x100e_9085:
            ii(0x100e_9085, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100e_9088, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100e_908b, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100e_908e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_9090, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_9091, 1); popd(edi);                              /* pop edi */
            ii(0x100e_9092, 1); popd(esi);                              /* pop esi */
            ii(0x100e_9093, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_9094, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_9095, 1); retd();                                 /* ret */
        }
    }
}
