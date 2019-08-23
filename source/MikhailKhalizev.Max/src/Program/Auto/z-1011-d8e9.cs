using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_d8e9-ea60d7cc")]
        public void Method_1011_d8e9()
        {
            ii(0x1011_d8e9, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1011_d8ee, 5); calld(Definitions.sys_check_available_stack_size, 0x4_845f); /* call 0x10165d52 */
            ii(0x1011_d8f3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_d8f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_d8f5, 1); pushd(esi);                             /* push esi */
            ii(0x1011_d8f6, 1); pushd(edi);                             /* push edi */
            ii(0x1011_d8f7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_d8f8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_d8fa, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_d900, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_d903, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_d906, 5); cmp(memw_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x1011_d90b, 2); if(jnzd(0x1011_d91c, 0xf)) goto l_0x1011_d91c; /* jnz 0x1011d91c */
            ii(0x1011_d90d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_d90f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_d912, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1011_d915, 5); calld(0x1007_6630, -0xa_72ea);          /* call 0x10076630 */
            ii(0x1011_d91a, 2); jmpd(0x1011_d97f, 0x63); goto l_0x1011_d97f; /* jmp 0x1011d97f */
        l_0x1011_d91c:
            ii(0x1011_d91c, 5); mov(eax, 0xe1);                         /* mov eax, 0xe1 */
            ii(0x1011_d921, 5); calld(Definitions.sys_new, 0x4_84da);   /* call 0x10165e00 */
            ii(0x1011_d926, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_d929, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_d92c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_d92f, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1011_d933, 2); if(jzd(0x1011_d96b, 0x36)) goto l_0x1011_d96b; /* jz 0x1011d96b */
            ii(0x1011_d935, 5); calld(0x1008_ac70, -0x9_2cca);          /* call 0x1008ac70 */
            ii(0x1011_d93a, 1); cwde();                                 /* cwde */
            ii(0x1011_d93b, 1); pushd(eax);                             /* push eax */
            ii(0x1011_d93c, 5); mov(ecx, 0xffff);                       /* mov ecx, 0xffff */
            ii(0x1011_d941, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_d944, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1011_d947, 5); calld(0x1007_6574, -0xa_73d8);          /* call 0x10076574 */
            ii(0x1011_d94c, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1011_d94f, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_d951, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_d954, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1011_d958, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_d95b, 5); calld(0x1014_9237, 0x2_b8d7);           /* call 0x10149237 */
            ii(0x1011_d960, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_d963, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_d966, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_d969, 2); jmpd(0x1011_d971, 0x6); goto l_0x1011_d971; /* jmp 0x1011d971 */
        l_0x1011_d96b:
            ii(0x1011_d96b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_d96e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1011_d971:
            ii(0x1011_d971, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1011_d974, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_d977, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1011_d97a, 5); calld(0x1007_6630, -0xa_734f);          /* call 0x10076630 */
        l_0x1011_d97f:
            ii(0x1011_d97f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_d981, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_d982, 1); popd(edi);                              /* pop edi */
            ii(0x1011_d983, 1); popd(esi);                              /* pop esi */
            ii(0x1011_d984, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_d985, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_d986, 1); retd();                                 /* ret */
        }
    }
}
