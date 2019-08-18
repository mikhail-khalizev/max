using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cca97295-4322-4d2c-8cf8-d9655af3a48a")]
        public void Method_1009_e939()
        {
            ii(0x1009_e939, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_e93e, 5); calld(Definitions.sys_check_available_stack_size, 0xc_740f); /* call 0x10165d52 */
            ii(0x1009_e943, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_e944, 1); pushd(esi);                             /* push esi */
            ii(0x1009_e945, 1); pushd(edi);                             /* push edi */
            ii(0x1009_e946, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_e947, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_e949, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_e94f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_e952, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_e955, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_e958, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_e95b, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1009_e95d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_e960, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_e965, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e968, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_e96b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_e96e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_e971, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_e973, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_e975, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_e977, 5); mov(eax, memd_a32[ds, 0x101c_811c]);    /* mov eax, [0x101c811c] */
            ii(0x1009_e97c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_e97e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_e980, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x1009_e983, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_e986, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_e989, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e98c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_e992, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1009_e998, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_e99b, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1009_e9a0, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1009_e9a2, 2); if(jzd(0x1009_e9aa, 0x6)) goto l_0x1009_e9aa; /* jz 0x1009e9aa */
            ii(0x1009_e9a4, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1009_e9a8, 2); jmpd(0x1009_e9ae, 0x4); goto l_0x1009_e9ae; /* jmp 0x1009e9ae */
        l_0x1009_e9aa:
            ii(0x1009_e9aa, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1009_e9ae:
            ii(0x1009_e9ae, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1009_e9b1, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1009_e9b4, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1009_e9b7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_e9b9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_e9ba, 1); popd(edi);                              /* pop edi */
            ii(0x1009_e9bb, 1); popd(esi);                              /* pop esi */
            ii(0x1009_e9bc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_e9bd, 1); retd(); return;                         /* ret */
        }
    }
}
