using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("606e008b-2c92-4384-b6d7-129d431d2db9")]
        public void Method_100c_90d6()
        {
            ii(0x100c_90d6, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100c_90db, 5); calld(Definitions.sys_check_available_stack_size, 0x9_cc72); /* call 0x10165d52 */
            ii(0x100c_90e0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_90e1, 1); pushd(esi);                             /* push esi */
            ii(0x100c_90e2, 1); pushd(edi);                             /* push edi */
            ii(0x100c_90e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_90e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_90e6, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100c_90ec, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_90ef, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_90f2, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_90f5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_90f8, 5); calld(0x100c_8b2c, -0x5d1);             /* call 0x100c8b2c */
            ii(0x100c_90fd, 6); test(memw_a32[ss, ebp - 0x4], 0x2);     /* test word [ebp-0x4], 0x2 */
            ii(0x100c_9103, 2); if(jzd(0x100c_9136, 0x31)) goto l_0x100c_9136; /* jz 0x100c9136 */
            ii(0x100c_9105, 6); test(memw_a32[ss, ebp - 0x4], 0x1);     /* test word [ebp-0x4], 0x1 */
            ii(0x100c_910b, 2); if(jzd(0x100c_9116, 0x9)) goto l_0x100c_9116; /* jz 0x100c9116 */
            ii(0x100c_910d, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100c_9114, 2); jmpd(0x100c_9154, 0x3e); goto l_0x100c_9154; /* jmp 0x100c9154 */
        l_0x100c_9116:
            ii(0x100c_9116, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_9119, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_911c, 5); calld(0x1007_5e64, -0x5_32bd);          /* call 0x10075e64 */
            ii(0x100c_9121, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_9123, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_9126, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_9129, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_912c, 5); calld(0x100c_8eef, -0x242);             /* call 0x100c8eef */
            ii(0x100c_9131, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_9134, 2); jmpd(0x100c_9154, 0x1e); goto l_0x100c_9154; /* jmp 0x100c9154 */
        l_0x100c_9136:
            ii(0x100c_9136, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_9139, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_913c, 5); calld(0x1007_5e64, -0x5_32dd);          /* call 0x10075e64 */
            ii(0x100c_9141, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_9143, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_9146, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100c_9149, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_914c, 5); calld(0x100c_8eef, -0x262);             /* call 0x100c8eef */
            ii(0x100c_9151, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100c_9154:
            ii(0x100c_9154, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_9157, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_9159, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_915a, 1); popd(edi);                              /* pop edi */
            ii(0x100c_915b, 1); popd(esi);                              /* pop esi */
            ii(0x100c_915c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_915d, 1); retd(); return;                         /* ret */
        }
    }
}
